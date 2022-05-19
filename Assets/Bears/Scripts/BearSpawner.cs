using UnityEngine;

public class BearSpawner : MonoBehaviour{

	[SerializeField] private GameObject bearPrefab;

	// locations, where bears can spawn
	[SerializeField] private Transform[] spawnLocations;

	// spawn time
	[SerializeField] private float spawnDelay;
	private float spawnTimer;

	// example timed bear spawner
	private void FixedUpdate() {
		if (spawnTimer > 0)
			spawnTimer -= Time.fixedDeltaTime;
		else {
			SpawnNextBear();
			spawnTimer = spawnDelay;
		}
	}

	// call this to spawn a bear
	public void SpawnNextBear() {
		// choosing spawn location
		int nextSpawnIndex = Random.Range(0, spawnLocations.Length);

		// spawn a bear
		Instantiate(bearPrefab, spawnLocations[nextSpawnIndex].position, Quaternion.identity);
	}
}