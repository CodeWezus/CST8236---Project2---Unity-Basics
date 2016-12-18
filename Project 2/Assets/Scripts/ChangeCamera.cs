using UnityEngine;
using System.Collections;

public class ChangeCamera : MonoBehaviour {

    private Camera cam;

	// Use this for initialization
	void Start () {
        cam = GetComponent<Camera>();
    }
	
	// Update is called once per frame
	void Update () {

        // If space is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //switch camera mode
            cam.orthographic = !cam.orthographic;
        }

    }
}
