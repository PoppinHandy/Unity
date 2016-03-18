using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	public Text lifeBarText;
	public static int life;

	void Start(){
		life = 3;
		lifeBarText.text = "Lives: " + life;
	}

	void Awake(){
		DontDestroyOnLoad (this);
	}

	// Update is called once per frame
	void Update () {
		lifeBarText.text = "Lives: " + life;
	}
		
}
