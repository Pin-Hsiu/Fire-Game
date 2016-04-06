using UnityEngine;
using System.Collections;

public class NavWalk : MonoBehaviour {


	int direction; 
	GameObject model;


	void Start () 
	{
		model = GameObject.Find("suitF01"); 
		direction= Random.Range(0, 4);


	}

	void Update () 
	{
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
