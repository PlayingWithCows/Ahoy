using UnityEngine;
using System.Collections;
using UnityEngine.Networking;

public class MyNetworkManager : NetworkManager {

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void MyStartHost(){
		
	StartHost();

	}

	public override void OnStartHost(){
		Debug.Log ("Server Started at: " + System.DateTime.Now);
	}
}
