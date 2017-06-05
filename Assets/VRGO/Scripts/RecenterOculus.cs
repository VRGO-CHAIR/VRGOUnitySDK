/* A basic recenter script for Oculus. You may need this if you wish to allow the player to recenter themselves. 
 * The user may need to recenter themselves at the start of an experience to ensure the chair and HMD forwards are
 * the same.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VR;

public class RecenterOculus : MonoBehaviour {

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.F1))
        {
            Reset();
        }
    }

    public void Reset()
    {
        InputTracking.Recenter();
    }
}
