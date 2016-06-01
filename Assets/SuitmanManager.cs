using UnityEngine;


public class SuitmanManager : MonoBehaviour {

	// Use this for initialization

	
		public PlayerHealth playerHealth;       // Reference to the player's heatlh.
		public GameObject Suitman;                // The enemy prefab to be spawned.
		public float spawnTime = 3f;            // How long between each spawn.
		public Transform[] spawnPoints;         // An array of the spawn points this enemy can spawn from.
	    public int number = 0; 


		void Start ()
		{
		
		int i = 0;
		for (i = 0; i < number; i++) {
			Invoke ("Spawn", spawnTime);
		}
		//Invoke ("Spawn", 0f);
		//Invoke ("Spawn", 0f);

		}


		void Spawn ()
		{
			// If the player has no health left...
			

			// Find a random index between zero and one less than the number of spawn points.
			int spawnPointIndex = Random.Range (0, spawnPoints.Length);

			// Create an instance of the enemy prefab at the randomly selected spawn point's position and rotation.
			Instantiate (Suitman, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);

		}
}
