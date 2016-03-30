using UnityEngine;
using System.Collections;

public class NavMeshMove : MonoBehaviour {

	public Transform[] NavMeshTransforms;//导航网格的目的地组。

	private NavMeshAgent nma;//Robot的导航网格代理

	void Start () {
		if(NavMeshTransforms == null)
		{
			return;
		}
		nma = gameObject.GetComponent<NavMeshAgent>();
		nma.SetDestination(NavMeshTransforms[0].position);//初始时刻设置的导航网格代理的目的地
	}

	void Update () {

		if(nma.remainingDistance == 0){
			//当导航网格代理到达了目的地时，更换目的地，且是随机的更换
			nma.SetDestination(NavMeshTransforms[Random.Range(0,NavMeshTransforms.Length)].position);
		}
	}
}