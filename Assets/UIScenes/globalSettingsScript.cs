using UnityEngine;
using System.Collections;

public class globalSettingsScript : MonoBehaviour {
	
	public int score = 0;
	public int miss = 0;
	
	// Use this for initialization
	void Start () {
		DontDestroyOnLoad(this);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void resetGameStats() {
		this.score = 0; 
		this.miss = 0;
		print ("Seting score and miss to "+score+ " and "+miss);
	}
}
