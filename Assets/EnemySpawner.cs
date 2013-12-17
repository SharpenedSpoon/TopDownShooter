using UnityEngine;
using System.Collections;

public class EnemySpawner : MonoBehaviour {

	public GameObject enemy;

	private Vector3 RandomSpawnPoint() {
		float x = Random.Range(0, 200.0f);
		float z = Random.Range(0, 200.0f);
		Vector3 spawnPoint = new Vector3(x, 0.0f, z);
		spawnPoint.y = Terrain.activeTerrain.SampleHeight(spawnPoint);
		return spawnPoint;
	}

	public void RandomlySpawnEnemies(int num) {
		for (int i=0; i<num; i++) {
			//TODO make these work. it's late right now and I just wanna bea ble to play this for now.
			//float x = Random.Range(0, Terrain.activeTerrain.terrainData.heightmapWidth);
			//float z = Random.Range(0, Terrain.activeTerrain.terrainData.heightmapHeight);


			Instantiate(enemy, RandomSpawnPoint(), Quaternion.identity);
		}
	}

	public GameObject SpawnEnemy() {
		GameObject output = Instantiate(enemy, RandomSpawnPoint(), Quaternion.identity) as GameObject;
		return output;
	}
}
