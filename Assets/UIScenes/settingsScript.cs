using UnityEngine;
using System.Collections;

public class settingsScript : MonoBehaviour {
	
	private float bbx = 50;
	private float bby = 50;
	private float bbw = 100;
	private float bbh = 50;	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	void OnGUI(){
		if(GUI.Button(new Rect(bbx,bby,bbw,bbh),"Back")){
			Application.LoadLevel("sceneMainMenu");	
		}
	}	
	
}
