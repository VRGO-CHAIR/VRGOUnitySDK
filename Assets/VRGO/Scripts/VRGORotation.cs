using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Rewired;

public class VRGORotation : MonoBehaviour {

    public int playerId = 0; // The Rewired player id of this character
    private Player player; // The Rewired Player
    public float turnSensitivity = 3f;
    bool initialized;
    Vector3 startRot;

    void Awake()
    {
        startRot = transform.rotation.eulerAngles;
    }

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

        if (Input.GetKeyUp(KeyCode.F1))
        {
            Reset();
        }

        ProcessInput();
    }

    void Reset()
    {
        transform.rotation = Quaternion.Euler(startRot);
    }

    // Update is called once per frame
    void ProcessInput() {
        transform.Rotate(new Vector3(0, player.GetAxis("Right Stick X") * turnSensitivity, 0));
    }
}
