using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public GameObject player;
	//private Sprite bg;
	public float xMin, xMax, yMin, yMax;
	//private Transform camPos;

	// Use this for initialization
	void Start () {
		//Calculate and store the offset value by getting the distance between the player's position and camera's position.
		//offset = transform.position - player.transform.position;
		//bg = GameObject.FindGameObjectWithTag ("Background").GetComponent<SpriteRenderer> ().sprite;
		//camPos = GetComponent<Transform> ();
	}

	// Update is called once per frame
	void Update () {
		transform.position = new Vector3
			(
				Mathf.Clamp(player.transform.position.x, xMin, xMax),
				Mathf.Clamp (player.transform.position.y, yMin, yMax),
				-20	
			); 
				
	}

}
