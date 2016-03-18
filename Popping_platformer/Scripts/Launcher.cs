using UnityEngine;
using System.Collections;

public class Launcher : MonoBehaviour {

	public GameObject missile;
	// Use this for initialization
	void Start () {
		Spawn ();
	}
	
	// Update is called once per frame
	void Spawn () {
		Instantiate(missile, transform.position, transform.rotation);
		Invoke ("Spawn", 6);
	}


}
