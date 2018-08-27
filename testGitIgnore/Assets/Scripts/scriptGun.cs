using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptGun : MonoBehaviour {
    [SerializeField] GameObject gun;
    [SerializeField] Camera PlayerCamera;
    [SerializeField] GameObject player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetAxis("Mouse X") != 0)
        {
            player.transform.Rotate(0, Input.GetAxis("Mouse X") * 50, 0);
        }
        //if (Input.GetAxis("Mouse Y") != 0)
        //{
        //    PlayerCamera.transform.Rotate(-Input.GetAxis("Mouse X")*2,0,0);
        //}

    }
}
