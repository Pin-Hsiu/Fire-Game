using UnityEngine;
using System.Collections;

public class LineWalk : MonoBehaviour {

	void Update () {
		float translation = Time.deltaTime * 10;
		transform.Translate(0, 0, translation);

	}


	void OnCollisionEnter(Collision other)
	{
		if (other.gameObject.name == "RightSide") 
		{
			transform.Rotate (0, -90, 0);
		}
	}



			
}