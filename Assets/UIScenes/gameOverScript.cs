using UnityEngine;
using System.Collections;

public class gameOverScript : MonoBehaviour {

	private float bbx = 50;
	private float bby = 50;
	private float bbw = 100;
	private float bbh = 50;	

	private GameObject globalSettings;
	private globalSettingsScript script;
	
	// Use this for initialization
	void Start () {
		globalSettings = GameObject.Find("GlobalSettings");
		script= (globalSettingsScript)globalSettings.GetComponent("globalSettingsScript");
	}
	
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		GUI.Label(new Rect(bbx,bby,bbw,bbh),"GAME OVER!!: ");
		GUI.Label(new Rect(bbx,bby+50,bbw+100,bbh),"You kill "+script.score + " out of "+ (script.score + script.miss) + " ducks");	
		if(GUI.Button(new Rect(bbx,bby+100,bbw,bbh),"Main Menu")){
			Application.LoadLevel("sceneMainMenu");	
		}		
	}
	
}
