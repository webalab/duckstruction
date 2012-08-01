using UnityEngine;
using System.Collections;

public class gameScreenScript : MonoBehaviour {

	private float bbx = 50;
	private float bby = 50;
	private float bbw = 100;
	private float bbh = 50;	

	private GameObject globalSettings;
	public GameObject bullet;
	private globalSettingsScript script;
	
	// Use this for initialization
	void Start () {
		globalSettings = GameObject.Find("GlobalSettings");
		script= (globalSettingsScript)globalSettings.GetComponent("globalSettingsScript");
		//script.resetGameStats();
	}
	
	// Update is called once per frame
	void Update () {
		if( (script.score + script.miss ) >= 16 ){
			Application.LoadLevel ("sceneGameOver");
		}
		
		if( Input.GetMouseButtonDown(0) ){
			Ray ray = Camera.mainCamera.ScreenPointToRay(Input.mousePosition);
			RaycastHit hit; 
	        if (Physics.Raycast(ray, out hit, 1000)){
				print("CLOOCK");
		
			/* INSTANCIATE PROGRAMMATICALLY
				GameObject projectile = (GameObject)Instantiate(bullet,
                                    new Vector3(-5.0f,12.0f,73.0f),
                                      transform.rotation);
			*/	
		//		projectile.rigidbody.AddExplosionForce(1000,new Vector3(0,75,50),100);
        	//projectile.rigidbody.AddForce(new Vector3(-5.0f,150f,73.0f)*1000);//cannon's x axis
        //Physics.IgnoreCollision(projectile.collider, collider);
			}
		}
	}
	


	void OnGUI(){
		GUI.Label(new Rect(bbx,bby,bbw,bbh),"Score: "+script.score + "/ "+script.miss);
	}	
}
