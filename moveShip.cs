using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveShip : MonoBehaviour {
	public Vector2 speed;
	public Vector2 movement;
	
    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        float inputY = Input.GetAxis("Vertical");
        float inputX = Input.GetAxis("Horizontal");
        
        movement = new Vector2(speed.x*inputX, speed.y*inputY);
        
        GetComponent<Rigidbody2D>().velocity = movement;
    }
}
