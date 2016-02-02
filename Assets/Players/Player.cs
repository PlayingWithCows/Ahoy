using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.Networking;

public class Player : NetworkBehaviour {

	public float movespeed = 10;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(!isLocalPlayer){return;}

		transform.Translate(new Vector3(CrossPlatformInputManager.GetAxis("Horizontal")*movespeed*Time.deltaTime,0f,CrossPlatformInputManager.GetAxis("Vertical")*movespeed*Time.deltaTime));

	}
}
