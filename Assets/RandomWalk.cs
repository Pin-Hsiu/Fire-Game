using UnityEngine;
using System.Collections;

public class RandomWalk : MonoBehaviour {
	/*void start(){
		InvokeRepeating("Update",1,1);
	}*/


	void Update () {
		float time=0;


		for (time = 0; time < 10000F; time += 10*Time.deltaTime) {

			float i = Random.Range (-2F, 2F);
				gameObject.transform.Translate (i*Time.deltaTime, 0, 0);
				delay (10000);

				gameObject.transform.Translate (0, 0, i*Time.deltaTime);
				delay (10000);
			
		}
	}


	void delay(int t){
		int x;
		for (x = 0; x < t; x++)
			;
		}
}
