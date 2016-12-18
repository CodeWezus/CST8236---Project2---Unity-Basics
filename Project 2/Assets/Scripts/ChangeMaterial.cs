using UnityEngine;
using System.Collections;

public class ChangeMaterial : MonoBehaviour {
    
    public Material[] materials = new Material[6];
    public MeshRenderer meshRend;

    // Use this for initialization
    void Start () {
        meshRend = GetComponent<MeshRenderer>();
    }
	
	// Update is called once per frame
	void Update () {
        
        // Depending on which key the user presses, switch to the corresponding material.

        if (Input.GetKeyDown(KeyCode.Keypad1)|| Input.GetKeyDown(KeyCode.Alpha1))
        {
            meshRend.material = materials[0];
        }
        else if (Input.GetKeyDown(KeyCode.Keypad2) || Input.GetKeyDown(KeyCode.Alpha2))
        {
            meshRend.material = materials[1];
        }
        else if (Input.GetKeyDown(KeyCode.Keypad3) || Input.GetKeyDown(KeyCode.Alpha3))
        {
            meshRend.material = materials[2];
        }
        else if (Input.GetKeyDown(KeyCode.Keypad4) || Input.GetKeyDown(KeyCode.Alpha4))
        {
            meshRend.material = materials[3];
        }
        else if (Input.GetKeyDown(KeyCode.Keypad5) || Input.GetKeyDown(KeyCode.Alpha5))
        {
            meshRend.material = materials[4];
        }
        else if (Input.GetKeyDown(KeyCode.Keypad6) || Input.GetKeyDown(KeyCode.Alpha6))
        {
            meshRend.material = materials[5];
        }
        else
            return;


    }
}
