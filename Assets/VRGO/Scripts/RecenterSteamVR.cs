/* A basic recenter script for SteamVR. You may need this if you wish to allow the player to recenter themselves. 
 * The user may need to recenter themselves at the start of an experience to ensure the chair and HMD forwards are
 * the same.
 * 
 * NOTE: The SteamVR Plugin needs to be in your project for this to compile. Also, recentering only works if your
 * experience is Seated.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Valve.VR;

public class RecenterSteamVR : MonoBehaviour {

    private void Awake()
    {
        OpenVR.Compositor.SetTrackingSpace(ETrackingUniverseOrigin.TrackingUniverseSeated);
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.F1))
        {
            Reset();
        }
    }

    private void Reset()
    {
        OpenVR.System.ResetSeatedZeroPose();

        OpenVR.Compositor.SetTrackingSpace(ETrackingUniverseOrigin.TrackingUniverseSeated);
    }

}
