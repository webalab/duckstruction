using UnityEngine;
using System.Collections;

public class gameScreenScript : MonoBehaviour {

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
		script.resetGameStats();
	}
	
	// Update is called once per frame
	void Update () {
		//print (script.score+" >");
		
		if( (script.score + script.miss ) >= 16 ){
			Application.LoadLevel ("sceneGameOver");
		}
	}
	
	void OnGUI(){
		GUI.Label(new Rect(bbx,bby,bbw,bbh),"Score: "+script.score + "/ "+script.miss);
	}	
}
