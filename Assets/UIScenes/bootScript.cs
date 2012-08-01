using UnityEngine;
using System.Collections;

public class bootScript : MonoBehaviour {
	
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
		if(GUI.Button(new Rect(bbx,bby,bbw,bbh),"Continue...")){
			script.resetGameStats();
			Application.LoadLevel("sceneMainMenu");	
		}
	}
	
}
