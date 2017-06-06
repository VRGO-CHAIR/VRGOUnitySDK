/*A basic implementation of movement with the VRGO chair. This can be used as a basis or implementing movement into your game
 * or you may wish to copy the important parts into your own solution.
 * 
 */

using UnityEngine;
using UnityEngine.VR;
using System.Collections;
using Rewired;

[AddComponentMenu("")]
public class VRGOMovement : MonoBehaviour
{

    public int playerId = 0; // The Rewired player id of this character

    // Movement speed, can be increased/decreased based on preference.
    public float movementSpeed = 3.0f;

    private Player player; // The Rewired Player

    [SerializeField]
    private CharacterController cc;

    // Are we moving based on the camera's direction or the character's rotation.
    [SerializeField]
    bool useCameraForward;

    // Player camera transform used for player to determine direction (if camera forward mode is on);
    [SerializeField]
    Transform playerCamera;

    [System.NonSerialized] // Don't serialize this so the value is lost on an editor script recompile.
    private bool initialized;

    private void Initialize()
    {
        // Get the Rewired Player object for this player.
        player = ReInput.players.GetPlayer(playerId);

        initialized = true;
    }

    void Update()
    {
        if (!ReInput.isReady) return; // Exit if Rewired isn't ready. This would only happen during a script recompile in the editor.
        if (!initialized) Initialize(); // Reinitialize after a recompile in the editor

        ProcessInput();
    }

    private void ProcessInput()
    {
        // Get the input from the Rewired Player. All controllers that the Player owns will contribute, so it doesn't matter
        // whether the chair is in keyboard/mouse mode or joystick mode.

        Vector3 moveVec = new Vector3();
        moveVec.x = player.GetAxis("Left Stick X") * movementSpeed; // get input by name or action id
        moveVec.z = player.GetAxis("Left Stick Y") * movementSpeed;

        // So if we're not using the camera to determine our direction of movement, we'll just move based on the rotation of this gameobject.
        if (!useCameraForward)
        {
            moveVec = transform.rotation * moveVec;
        }
        // else we'll use the camera's rotation and multiply the movement vector with it.
        else
        {
            // Slight difference to video as we need to not use x and Z of the camera rotation.
            moveVec = Quaternion.Euler(0,playerCamera.rotation.eulerAngles.y, 0) * moveVec;
        }

        // Then move it.
        cc.Move(moveVec * Time.deltaTime);

    }

}