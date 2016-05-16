using UnityEngine;
using System.Collections;

public class Bloodtwo : MonoBehaviour {

	public GameObject bloodBar;//获取血条信息。  
	public Vector3 offset;  //血条和人物坐标的差值,也就是血条在人物的上中方...之类的.这样理解
	private GameObject player;
	// Use this for initialization

	void Awake ()
	{
		player = GameObject.FindGameObjectWithTag ("Player1");
	}
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		//让血条信息一直处于人物的头顶某处
		bloodBar.transform.position=player.transform.position+offset;


	}

}