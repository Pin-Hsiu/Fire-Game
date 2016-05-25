using UnityEngine;
using System.Collections;

public class NavWalk : MonoBehaviour {


	int direction; 
    GameObject model;
	public const int Obstacle_DISTANCE = 13;
	public int walktype= 0;
	public Transform target;
	private NavMeshAgent navMeshAgent;


	void Awake ()
	{
		model = this.gameObject; 
		//target = GameObject.Find("Target");
	}

	void Start () 
	{
		if (walktype == 1) {
			direction = Random.Range (0, 4);
		}
		walktype = 2;
		Debug.Log ("time");
		navMeshAgent = GetComponent<NavMeshAgent>();
	}


	void awake(){
		
	}





	void Update ()
	{

		//Debug.Log (model.name + " : " + walktype);
		switch (walktype)
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

			navMeshAgent.destination = target.position;

			break;


		default:
			model.transform.Translate (0, 0, -0.3f);
			break;





		}
	}
} 
