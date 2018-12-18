using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {

	public int damage = 1; 
	public float speed = 5; 

	void OnTriggerEnter2D(Collider2D other){ //Called whenever "Obstacle" collides with something, only gets called if object is marked as trigger.
		if (other.CompareTag("Player")) {
			
			other.GetComponent<Player>().health -= damage;
			Destroy(gameObject);
			Debug.Log(other.GetComponent<Player>().health);
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		transform.Translate( new Vector2(-1,0) * speed * Time.deltaTime);
	
	}
}
