using UnityEngine;
using System.Collections;

public class NavWalk : MonoBehaviour {

	GameObject build;
	GameObject buildelement1;
	GameObject buildelement2;
	int direction; 
	GameObject model;
	public const int Obstacle_DISTANCE = 13;



	void Awake ()
	{
		
	}

	void Start () 
	{
		model = GameObject.Find("suitF01"); 
		direction= Random.Range(0, 4);
		build = GameObject.Find("Lamp");
		buildelement1 = GameObject.Find("Lamp(1)");
		buildelement2 = GameObject.Find("Lamp(2)");
	}








	void Update () 
	{
		

		 if(direction == 0 ) 
		{
			if (Vector3.Distance (transform.position, build.transform.position) <
			    (Obstacle_DISTANCE)) {
				model.transform.Translate (0, 0, 0.3f);
			} 
			else if (Vector3.Distance (transform.position, buildelement1.transform.position) <
				(Obstacle_DISTANCE)) {
				model.transform.Translate (0, 0, 0.3f);
			} 
			else if (Vector3.Distance (transform.position, buildelement2.transform.position) <
				(Obstacle_DISTANCE)) {
				model.transform.Translate (0, 0, 0.3f);
			} 
			else {
				model.transform.Translate (0.3f, 0, 0);
				if (model.transform.position.x >= 50) {
					direction = 1; 
				}
			}
		}



		if (direction == 1 ) 
		{
			if (Vector3.Distance (transform.position, build.transform.position) <
			    (Obstacle_DISTANCE)) {
				model.transform.Translate (-0.3f, 0,0);
			} 
			else if (Vector3.Distance (transform.position, buildelement1.transform.position) <
				(Obstacle_DISTANCE)) {
				model.transform.Translate (-0.3f, 0,0);
			} 
			else if (Vector3.Distance (transform.position, buildelement2.transform.position) <
				(Obstacle_DISTANCE)) {
				model.transform.Translate (-0.3f, 0,0);
			} 
			else {
				model.transform.Translate (0, 0, 0.3f);

				if (model.transform.position.z >= 50) {
					direction = 2; 
				}
			}
		}


		if (direction == 2 ) 
		{
			if (Vector3.Distance (transform.position, build.transform.position) <
			    (Obstacle_DISTANCE)) {
				model.transform.Translate (0, 0, -0.3f);
			}
			else if (Vector3.Distance (transform.position, buildelement1.transform.position) <
				(Obstacle_DISTANCE)) {
				model.transform.Translate (0, 0, -0.3f);
			}
			else if (Vector3.Distance (transform.position, buildelement2.transform.position) <
				(Obstacle_DISTANCE)) {
				model.transform.Translate (0, 0, -0.3f);
			}
			else {
				model.transform.Translate (-0.3f, 0, 0);

				if (model.transform.position.x <= -50) {
					direction = 3;
				}
			}
		}



		if (direction == 3 ) 
		{
			if (Vector3.Distance (transform.position, build.transform.position) <
			    (Obstacle_DISTANCE)) {
				model.transform.Translate (0.3f, 0, 0);
			}
			else if (Vector3.Distance (transform.position, buildelement1.transform.position) <
				(Obstacle_DISTANCE)) {
				model.transform.Translate (0.3f, 0, 0);
			}
			else if (Vector3.Distance (transform.position, buildelement2.transform.position) <
				(Obstacle_DISTANCE)) {
				model.transform.Translate (0.3f, 0, 0);
			}
			else {
				model.transform.Translate (0, 0, -0.3f);

				if (model.transform.position.z <= -50) {	
					direction = 0; 
				}
			}
		}






	}


} 
