using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RPS : MonoBehaviour {
	public bool isChoose = true;

	[System.Serializable]
	public class Set {
		public Image[] imgs;
	}
	public Text countdownText;
	public int time = 5;
	private int timer;

	public Set player;
	public Set com;


	// Use this for initialization
	void Start () {
		ResetTimer ();
	}
	public void ResetTimer (){
		CancelInvoke ("ResetTimer");
		timer = time;
		Countdown ();
	}
	void Countdown () {
		Debug.Log (timer);
		timer = timer - 1;
		if (timer <= 0) {
			// Com play.
			int comChoose = Random.Range(0,3);
			for (int i = 0; i < 3; i++) {
				if (i == comChoose) {
					com.imgs [i].enabled = true;
				}
				else {
					com.imgs [i].enabled = false;
					}
			}
		}
		else {
			Invoke ("Countdown", 1);
		}
	}


	// Update is called once per frame
	void Update () {
		// Player choose is Scissors.
		if (Input.GetKeyDown(KeyCode.A)) {
			player.imgs [0].enabled = true;
			player.imgs [1].enabled = false;
			player.imgs [2].enabled = false;
		}
		// Player choose is Rock.
		else if (Input.GetKeyDown(KeyCode.S)) {
			player.imgs [0].enabled = false;
			player.imgs [1].enabled = true;
			player.imgs [2].enabled = false;
		}
		// Player choose is Paper.
		else if (Input.GetKeyDown(KeyCode.D)) {
			player.imgs [0].enabled = false;
			player.imgs [1].enabled = false;
			player.imgs [2].enabled = true;
		}
		else {
		}
	}
}
