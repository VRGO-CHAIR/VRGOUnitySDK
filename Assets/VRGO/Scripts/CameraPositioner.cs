using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPositioner : MonoBehaviour {

    [SerializeField]
    Transform transformToCopy;
	// Update is called once per frame
	void Update () {
        transform.position = transformToCopy.position;
	}
}
