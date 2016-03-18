using UnityEngine;
using System.Collections;

public class MissileDestroyer : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other){

		if(other.gameObject.CompareTag("Rocket")){
			Destroy (other.gameObject);
		}
	}
}
