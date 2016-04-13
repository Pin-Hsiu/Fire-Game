using UnityEngine;
using System.Collections;

public class HMove : MonoBehaviour{

	void Update(){
		gameObject.transform.Translate (0, 0, 30* Time.deltaTime);
	}
}