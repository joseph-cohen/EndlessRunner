using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {
	
	public GameObject[] obstaclePatterns; 
	
	public static float startTime = 3f; 
	public float spawnTime = startTime;
	public float decreaseTime = 0.5f;
	public float minTime = 0.5f; 
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
		if (spawnTime <= 0) {
			
			int rand = Random.Range(0, obstaclePatterns.Length);
			Instantiate(obstaclePatterns[rand], transform.position, Quaternion.identity);
			spawnTime = startTime;
			
			if (spawnTime < minTime) {
				spawnTime = minTime;
			}

			if (startTime > minTime) {
				startTime -= decreaseTime;
			}
			
		} else {
			spawnTime -= 1 * Time.deltaTime;
		}
		
		
	}
}