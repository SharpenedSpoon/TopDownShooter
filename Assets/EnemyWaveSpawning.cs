using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class EnemyWaveSpawning : MonoBehaviour {

	public float waveTime = 15.0f;

	private float nextSpawnTime;
	private EnemySpawner spawner;

	private List<GameObject> enemies = new List<GameObject>();

	// Use this for initialization
	void Start () {
		spawner = GetComponent<EnemySpawner>();
		SpawnWave();
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time > nextSpawnTime) {
			SpawnWave();
		}
		EnsureSteadyFlowOfEnemies();
	}

	private void SpawnWave() {
		nextSpawnTime = Time.time + waveTime;
		spawner.RandomlySpawnEnemies(10);
	}

	private void EnsureSteadyFlowOfEnemies() {
		enemies.RemoveAll(IsNull);
		while (enemies.Count < 10) {
			enemies.Add (spawner.SpawnEnemy());
		}
	}

	private static bool IsNull(GameObject go) {
		return (go == null);
	}
}
