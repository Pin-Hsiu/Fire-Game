using UnityEngine;
using System.Collections;

public class NavWalk : MonoBehaviour {

	public int aaa; 
	GameObject model; 

	void Start () 
	{
		model = GameObject.Find("suitF01"); 
		aaa = Random.Range(0, 4);


	}

	void Update () 
	{
		if(aaa == 0 ) 
		{
			
			model.transform.Translate(0.3f,0,0);

			if (model.transform.position.x >= 50) 
				
			{
				aaa = 1; 
			
			}
		}

		if (aaa == 1 ) 
		{
			model.transform.Translate(0,0,0.3f);

			if (model.transform.position.z >= 50)

			{
				
				aaa = 2; 
			}
		}

		if (aaa == 2 ) 
		{
			model.transform.Translate(-0.3f,0,0);

			if (model.transform.position.x <= -50)
				
			{
				
				aaa = 3;
			}
		}

		if (aaa == 3 ) 
		{
			model.transform.Translate(0,0,-0.3f);

			if (model.transform.position.z <= -50)
				
			{
				
				aaa = 0; 
			}
		}
	}
} 
