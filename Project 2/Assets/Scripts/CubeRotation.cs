using UnityEngine;
using System.Collections;

public class CubeRotation : MonoBehaviour {

    private int rotateSpeed = 15;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        // Check if the up or down arrow is pressed and adjust rotation speed accordingly.
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            rotateSpeed = rotateSpeed + 3;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow)) {
            rotateSpeed = rotateSpeed - 3;
        }
        // Continuously rotate the cube in directions relative to frame time.
        transform.Rotate(Vector3.left * Time.deltaTime * rotateSpeed);
        transform.Rotate(Vector3.down * Time.deltaTime * rotateSpeed);
	}
}
