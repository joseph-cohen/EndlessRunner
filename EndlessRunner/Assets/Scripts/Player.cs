using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

	public string scene;
	
	private Vector2 targetPos;
	public float YIncrement; 
	public float speed; 
	public int maxHeight = 3;
	public int minHeight = -3;
	public int health = 3;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		if (health <= 2 ) {
            SceneManager.LoadScene("GameOver");
		}
	
		transform.position = Vector2.MoveTowards(transform.position, targetPos, speed*Time.deltaTime);
	
		if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight) {
			
			 targetPos = new Vector2(transform.position.x, transform.position.y + YIncrement);
			
		} else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight) {
			
			targetPos = new Vector2(transform.position.x, transform.position.y - YIncrement); 
		}
		
		if (transform.position.y > maxHeight) {
			transform.position = new Vector2(0, maxHeight);
		}
		
		if (transform.position.y < minHeight) {
			transform.position = new Vector2(0, minHeight);
		}
	}
}
