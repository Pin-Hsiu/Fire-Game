using UnityEngine;
using System.Collections;

public class NavWalk : MonoBehaviour {

	 GameObject build;
	//GameObject buildelement1;
	//GameObject buildelement2;
	int direction; 
	//int directions;
	GameObject model;
	public const int Obstacle_DISTANCE = 13;
	//GameObject models;



	void Awake ()
	{
		model = GameObject.FindGameObjectWithTag ("Player"); 
		build = GameObject.FindGameObjectWithTag("buildelement");
	}

	void Start () 
	{


			
			//models = GameObject.Find ("suitman(Clone)"); 
	
		direction= Random.Range(0, 4);
		//directions= Random.Range(0, 4);

		//buildelement1 = GameObject.Find("Lamp(1)");
		//buildelement2 = GameObject.Find("Lamp(2)");
	}


	void awake(){
		//model = GameObject.FindGameObjectWithTag ("Player");
	}





	void Update () 
	{
		/*邊緣躲避走法:
		一開始任意選上下左右一個方向走
		遇到障礙物的話會繞開他再恢復原來走的方向
		直到走到場景邊界
		(行走方向為上，會往左繞開 
			行走方向為下，會往右繞開
			行走方向為左，會往下繞開
			行走方向為右，會往上繞開
		)*/

		 if(direction == 0 ) 
		{
			if (Vector3.Distance (transform.position, build.transform.position) <
			    (Obstacle_DISTANCE)) {
				model.transform.Translate (0, 0, 0.3f);
			} 
			/*else if (Vector3.Distance (transform.position, buildelement1.transform.position) <
				(Obstacle_DISTANCE)) {
				model.transform.Translate (0, 0, 0.3f);
			} 
			else if (Vector3.Distance (transform.position, buildelement2.transform.position) <
				(Obstacle_DISTANCE)) {
				model.transform.Translate (0, 0, 0.3f);
			} */
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
			/*else if (Vector3.Distance (transform.position, buildelement1.transform.position) <
				(Obstacle_DISTANCE)) {
				model.transform.Translate (-0.3f, 0,0);
			} 
			else if (Vector3.Distance (transform.position, buildelement2.transform.position) <
				(Obstacle_DISTANCE)) {
				model.transform.Translate (-0.3f, 0,0);
			} */
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
			/*else if (Vector3.Distance (transform.position, buildelement1.transform.position) <
				(Obstacle_DISTANCE)) {
				model.transform.Translate (0, 0, -0.3f);
			}
			else if (Vector3.Distance (transform.position, buildelement2.transform.position) <
				(Obstacle_DISTANCE)) {
				model.transform.Translate (0, 0, -0.3f);
			}*/
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
			/*else if (Vector3.Distance (transform.position, buildelement1.transform.position) <
				(Obstacle_DISTANCE)) {
				model.transform.Translate (0.3f, 0, 0);
			}
			else if (Vector3.Distance (transform.position, buildelement2.transform.position) <
				(Obstacle_DISTANCE)) {
				model.transform.Translate (0.3f, 0, 0);
			}*/
			else {
				model.transform.Translate (0, 0, -0.3f);

				if (model.transform.position.z <= -50) {	
					direction = 0; 
				}
			}
		}



		/*if(directions == 0 ) 
		{
			if (Vector3.Distance (transform.position, build.transform.position) <
				(Obstacle_DISTANCE)) {
				models.transform.Translate (0, 0, 0.3f);
			} 
			else if (Vector3.Distance (transform.position, buildelement1.transform.position) <
				(Obstacle_DISTANCE)) {
				models.transform.Translate (0, 0, 0.3f);
			} 
			else if (Vector3.Distance (transform.position, buildelement2.transform.position) <
				(Obstacle_DISTANCE)) {
				models.transform.Translate (0, 0, 0.3f);
			} 
			else {
				models.transform.Translate (0.3f, 0, 0);
				if (models.transform.position.x >= 50) {
					directions = 1; 
				}
			}
		}



		if (directions == 1 ) 
		{
			if (Vector3.Distance (transform.position, build.transform.position) <
				(Obstacle_DISTANCE)) {
				models.transform.Translate (-0.3f, 0,0);
			} 
			else if (Vector3.Distance (transform.position, buildelement1.transform.position) <
				(Obstacle_DISTANCE)) {
				models.transform.Translate (-0.3f, 0,0);
			} 
			else if (Vector3.Distance (transform.position, buildelement2.transform.position) <
				(Obstacle_DISTANCE)) {
				models.transform.Translate (-0.3f, 0,0);
			} 
			else {
				models.transform.Translate (0, 0, 0.3f);

				if (models.transform.position.z >= 50) {
					directions = 2; 
				}
			}
		}


		if (directions == 2 ) 
		{
			if (Vector3.Distance (transform.position, build.transform.position) <
				(Obstacle_DISTANCE)) {
				models.transform.Translate (0, 0, -0.3f);
			}
			else if (Vector3.Distance (transform.position, buildelement1.transform.position) <
				(Obstacle_DISTANCE)) {
				models.transform.Translate (0, 0, -0.3f);
			}
			else if (Vector3.Distance (transform.position, buildelement2.transform.position) <
				(Obstacle_DISTANCE)) {
				models.transform.Translate (0, 0, -0.3f);
			}
			else {
				models.transform.Translate (-0.3f, 0, 0);

				if (models.transform.position.x <= -50) {
					directions = 3;
				}
			}
		}



		if (directions == 3 ) 
		{
			if (Vector3.Distance (transform.position, build.transform.position) <
				(Obstacle_DISTANCE)) {
				models.transform.Translate (0.3f, 0, 0);
			}
			else if (Vector3.Distance (transform.position, buildelement1.transform.position) <
				(Obstacle_DISTANCE)) {
				models.transform.Translate (0.3f, 0, 0);
			}
			else if (Vector3.Distance (transform.position, buildelement2.transform.position) <
				(Obstacle_DISTANCE)) {
				models.transform.Translate (0.3f, 0, 0);
			}
			else {
				models.transform.Translate (0, 0, -0.3f);

				if (models.transform.position.z <= -50) {	
					directions = 0; 
				}
			}
		}*/


	}


} 
