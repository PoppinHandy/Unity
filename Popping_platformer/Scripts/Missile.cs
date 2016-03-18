using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;


public class Missile : MonoBehaviour {

	private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
		if(transform.rotation.eulerAngles.z == 0)
		{
			rb2d.velocity = new Vector2 (2, 0);
		}else{
			rb2d.velocity = new Vector2 (-2, 0);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){

		if(other.gameObject.CompareTag("Player")){
			SceneManager.LoadScene(1);
		}
	}
}
