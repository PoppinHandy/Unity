using UnityEngine;
using System.Collections;


public class CloudPlatform : MonoBehaviour {


	public GameObject player;
	//private Collider2D col; 

	// Use this for initialization
	void Start () {
		//col = GetComponent<Collider2D> ();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (player.transform.position.y < this.transform.position.y) {
			gameObject.GetComponent<Collider2D>().enabled = false;
		} else 
		{
			gameObject.GetComponent<Collider2D>().enabled = true;
		}
	}
}
