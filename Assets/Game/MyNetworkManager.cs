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

	public override void OnStartClient(NetworkClient myclient){
		Debug.Log ("Client '"+myclient+"' was started at: " + System.DateTime.Now);
		
	}

	public override void OnClientConnect(NetworkConnection conn){
		Debug.Log ("Client has connected to '" + conn.address + "'at: " + System.DateTime.Now);
	}
}
