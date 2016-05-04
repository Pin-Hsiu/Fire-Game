using UnityEngine;
using System.Collections;

public class change : MonoBehaviour {
	GameObject model;
	// Use this for initialization
	void Start () {
	
		model = GameObject.Find("target"); 
	}
	
	// Update is called once per frame
	void Update () {
	
		int a;
		a = Random.Range(-50, 50);




		model.transform.position=Vector3(a,0,-a);
		
		yield return WaitForSeconds (6.0);



	
}
}