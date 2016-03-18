using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TitleScreen: MonoBehaviour {

	public Text title;
	public Text subtitle;
	public Text howto;

	void Start(){
		title.text = "Popping Club";
		subtitle.text = "The Game";
		howto.text = "<Any Key to Start>";
	}

	public void OnGUI(){
		if (Event.current.type == EventType.KeyDown) {
			LoadScene (1);
		}
	}

	public void LoadScene(int level)
	{
		SceneManager.LoadScene (1);
	}
}
