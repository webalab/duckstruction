using UnityEngine;
using System.Collections;

public class mainMenuScript : MonoBehaviour {

	
	
	private float sbx = 50;
	private float sby = 50;
	private float sbw = 100;
	private float sbh = 50;
	

	private float stbx = 160;
	private float stby = 50;
	private float stbw = 100;
	private float stbh = 50;
	

	private float ebx = 270;
	private float eby = 50;
	private float ebw = 100;
	private float ebh = 50;
		
	private GameObject globalSettings;
	private globalSettingsScript script;
	
	// Use this for initialization
	void Start () {
		globalSettings = GameObject.Find("GlobalSettings");
		script = (globalSettingsScript) globalSettings.GetComponent("globalSettingsScript");
		//
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnGUI(){
		if(GUI.Button(new Rect(sbx,sby,sbw,sbh),"Start")){
			script.resetGameStats();
			Application.LoadLevel("gameScreen");	
		}
		if(GUI.Button(new Rect(stbx,stby,stbw,stbh),"Settings")){
			Application.LoadLevel("sceneSettings");	
		}
		if(GUI.Button(new Rect(ebx,eby,ebw,ebh),"Exit")){
			Application.Quit();	
		}
	}

}
