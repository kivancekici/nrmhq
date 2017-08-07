using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CompleteCameraControllerrr : MonoBehaviour {

	public GameObject playerr;       //Public variable to store a reference to the player game object


	private Vector3 offsett;         //Private variable to store the offset distance between the player and camera

	// Use this for initialization
	void Start () 
	{
		//Calculate and store the offset value by getting the distance between the player's position and camera's position.
		offsett = transform.position - playerr.transform.position;
	}

	// LateUpdate is called after Update each frame
	void LateUpdate () 
	{
		// Set the position of the camera's transform to be the same as the player's, but offset by the calculated offset distance.
		transform.position = playerr.transform.position + offsett;
	}
}