using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour {

	public float speed;
	public float jumpSpeed;
	public Text coinCountText;
	private int coinCount;

	private Rigidbody2D rb2d;
	private SpriteRenderer ericWalk;
	private bool grounded;

	// Use this for initialization
	void Start () {
		coinCount = 0;
		coinCountText.text = "Beats Killed: " + coinCount;
		rb2d = GetComponent<Rigidbody2D> ();
		ericWalk = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		
		float moveHorizontal = Input.GetAxisRaw ("Horizontal"); //-1, 1, or 0
		Vector2 movement = new Vector2 (moveHorizontal, 0f); //left, right, or still vector
		rb2d.AddForce (movement * speed); //apply vector times speed

		if (Input.GetKey ("left")) {
			ericWalk.sprite = Resources.Load <Sprite> ("spaceboy");
		} else if (Input.GetKey ("right")) {
			ericWalk.sprite = Resources.Load <Sprite> ("spaceboy2");
		} //animation stuff



		if(Input.GetButton("Jump") && grounded){
			rb2d.AddForce(new Vector2(0f, jumpSpeed));
			grounded = false;
		}//if grounded, jump

		if (Input.GetKey ("down")) {
			rb2d.velocity = new Vector2(0,-15f);
		}
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.CompareTag ("Platform")) 
		{
			grounded = true;
		}//if he lands on platform, he can jump again
		else if(other.gameObject.CompareTag("Coin"))
		{
			coinCount++;
			coinCountText.text = "Beats Killed: " + coinCount;
			Destroy (other.gameObject);
		}
	}

	void OnTriggerExit2D(Collider2D other)
	{
		if (other.gameObject.CompareTag ("Platform")) {
			grounded = false;
		}
	}
}
