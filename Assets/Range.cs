using UnityEngine;
using System.Collections;

public class Range : MonoBehaviour {

	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame
	void Update () {
		ParticleSystem ps = GetComponent<ParticleSystem>();
		var sh = ps.shape;
		sh.enabled = true;
		sh.radius = sh.radius +2*Time.deltaTime;

	}
}
