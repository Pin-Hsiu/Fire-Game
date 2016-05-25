using UnityEngine;
using System.Collections;

public class Attack2 : MonoBehaviour
{
	public float timeBetweenAttacks = 0.5f;
	public int attackDamage = 10;


	Animator anim;
	GameObject player;
	GameObject fire;
	PlayerHealth playerHealth;
	//EnemyHealth enemyHealth;
	bool fireInRange;
	float timer;


	void Awake ()
	{
		fire = GameObject.FindGameObjectWithTag ("fire");
		player = GameObject.FindGameObjectWithTag ("Player");
		playerHealth = player.GetComponent <PlayerHealth> ();
		//enemyHealth = GetComponent<EnemyHealth>();
		anim = GetComponent <Animator> ();
	}


	void OnTriggerEnter (Collider other)
	{
		if(other.gameObject == fire)
		{
			fireInRange = true;
		}
	}


	void OnTriggerExit (Collider other)
	{
		if(other.gameObject == fire)
		{
			fireInRange = false;
		}
	}


	void Update ()
	{
		timer += Time.deltaTime;

		if(timer >= timeBetweenAttacks && fireInRange/* && enemyHealth.currentHealth > 0*/)
		{
			Attack ();
		}

		if(playerHealth.currentHealth <= 0)
		{
			anim.SetTrigger ("PlayerDead");
		}
	}


	void Attack ()
	{
		timer = 0f;

		if(playerHealth.currentHealth > 0)
		{
			playerHealth.TakeDamage (attackDamage);
		}
	}
}
