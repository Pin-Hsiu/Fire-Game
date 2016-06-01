using UnityEngine;
using System.Collections;

public class NavWalk : MonoBehaviour {


	int direction; 
    GameObject model;
	public const int Obstacle_DISTANCE = 13;
	public int walktype=1;
	//public Transform target;
	private NavMeshAgent navMeshAgent;
	GameObject target;
	GameObject model1;
	private NavWalk walkscript;
	public Transform[] points;
	private int destpoint = 0;


	void Awake ()
	{
		model = this.gameObject; 
		target = GameObject.Find("Target");
		//model1 = GameObject.Find("suitman");

	}

	void Start () 
	{
		
			direction = Random.Range (0, 4);
		
			//Debug.Log ("time");
		navMeshAgent = GetComponent<NavMeshAgent>();
		walkscript = GameObject.Find("suitman").GetComponent<NavWalk>() ;

		if (walkscript.walktype == 3) {
			navMeshAgent.autoBraking = false;
			GotoNext ();
		}


	}


	void awake(){
		

	}





	void Update ()
	{
		int alltype = walkscript.walktype;

		//Debug.Log (model.name + " : " + alltype);
		switch (alltype)
		{

		case 1:
		/*邊緣躲避走法:
		一開始任意選上下左右一個方向走
		遇到障礙物的話會繞開他再恢復原來走的方向
		直到走到場景邊界
		(行走方向為上，會往左繞開 
			行走方向為下，會往右繞開
			行走方向為左，會往下繞開
			行走方向為右，會往上繞開
		)*/

			if (direction == 0) {
				model.transform.Translate (0.3f, 0, 0);
				if (model.transform.position.x >= 48) {
					direction = 1; 
				}
			} else if (direction == 1) {
				model.transform.Translate (0, 0, 0.3f);

				if (model.transform.position.z >= 48) {
					direction = 2; 
				}
			} else if (direction == 2) {
				model.transform.Translate (-0.3f, 0, 0);

				if (model.transform.position.x <= -48) {
					direction = 3;
				}
			} else {
				model.transform.Translate (0, 0, -0.3f);

				if (model.transform.position.z <= -48) {	
					direction = 0; 
				}
			}
			break;

		case 2:

			navMeshAgent.destination = target.transform.position;

			break;

		case 3:
			if (navMeshAgent.remainingDistance < 0.5f)
				GotoNext ();
			break;

		default:
			model.transform.Translate (0, 0, -0.3f);
			if (model.transform.position.z <= -50) {	
				Destroy (model);
			}
			break;





		}
	}

	void GotoNext(){
		if (walkscript.points.Length == 0) {
			return;
		}
		navMeshAgent.destination = walkscript.points [destpoint].position;
		destpoint = (destpoint + 1) % walkscript.points.Length;
	}




} 
