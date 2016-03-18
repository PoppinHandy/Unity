using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour {
	public Text title;
	// Use this for initialization
	void Start () {
		title.text = "Congratulations";
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnGUI(){
		if (Event.current.type == EventType.KeyDown) {
			SceneManager.LoadScene (0);
		}
	}
}
