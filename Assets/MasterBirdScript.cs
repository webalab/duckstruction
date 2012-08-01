using UnityEngine;
using System.Collections;

public class MasterBirdScript : MonoBehaviour {
	
	private float speed = 1;
	private GameObject globalSettings;
	private globalSettingsScript script;
	private bool alive;
	
	// Use this for initialization
	void Start () {
		globalSettings = GameObject.Find("GlobalSettings");
		script= (globalSettingsScript)globalSettings.GetComponent("globalSettingsScript");
		speed = Random.Range(10,50);
		Vector3 position =  new Vector3(Random.Range (-100,-200), 35 ,Random.Range (50,100));
		transform.position = position;
		renderer.enabled = true;
		alive = true;
	}
	
	// Update is called once per frame
	void Update () {
		if(alive){
			//CHECK FOR FIRE
			if( Input.GetMouseButtonDown(0) ){
				Ray ray = Camera.mainCamera.ScreenPointToRay(Input.mousePosition);
				RaycastHit hit; 
		        if (Physics.Raycast(ray, out hit, 1000)){
					if(hit.transform == transform){
						renderer.enabled = false;
						alive = false;
						script.score ++;
						
					}
				}
		        
			}
			//CHECK TTL
			if( transform.position.x >= 50 ) {
				script.miss++;
				renderer.enabled = false;
				alive = false;
			}
			
			//Move the bird
			playerMovement();
		}
	}
	
		
	void playerMovement() {
		float playerSpeed = Time.deltaTime * speed;
		transform.Translate(playerSpeed, 0, 0);
	}

	
}
