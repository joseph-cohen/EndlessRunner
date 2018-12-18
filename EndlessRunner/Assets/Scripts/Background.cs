using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Background : MonoBehaviour
{
    public float Bspeed;
    public float endX;
    public float startX;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate( new Vector2(-1, 0) * Bspeed * Time.deltaTime);
        if (transform.position.x <= endX){
            Vector2 pos = new Vector2(startX, transform.position.y);
            transform.position = pos;
        }
    }
}
