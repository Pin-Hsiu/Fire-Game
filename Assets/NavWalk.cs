using UnityEngine;
using System.Collections;

public class NavWalk : MonoBehaviour {

	GameObject buildelement;
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
		buildelement = GameObject.Find("Lamp");

	}








	void Update () 
	{
		int s;
		if (Vector3.Distance (transform.position, buildelement.transform.position) <
		    (Obstacle_DISTANCE)) {
			for (s = 0; s < 10; s++) {
				model.transform.Translate(0,0,-0.3f *s*Time.deltaTime);
			}

			direction = 2;
		}



		 if(direction == 0 ) 
		{
			
			model.transform.Translate(0.3f,0,0);

			if (model.transform.position.x >= 50) 
				
			{
				direction = 1; 
			
			}
		}

		if (direction == 1 ) 
		{
			model.transform.Translate(0,0,0.3f);

			if (model.transform.position.z >= 50)

			{
				
				direction= 2; 
			}
		}

		if (direction == 2 ) 
		{
			model.transform.Translate(-0.3f,0,0);

			if (model.transform.position.x <= -50)
				
			{
				
				direction = 3;
			}
		}

		if (direction == 3 ) 
		{
			model.transform.Translate(0,0,-0.3f);

			if (model.transform.position.z <= -50)
				
			{
				
				direction = 0; 
			}
		}






	}


} 
