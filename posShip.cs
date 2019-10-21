using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class posShip : MonoBehaviour{
	
	private Vector3 rigthTopCameraBorder;
	private Vector3 leftTopCameraBorder;
	private Vector3 rigthBotCameraBorder;
	private Vector3 leftBotCameraBorder;
	
	private Vector2 siz;
    // Start is called before the first frame update
    void Start(){
		leftBotCameraBorder = Camera.main.ViewportToWorldPoint(new Vector3 (0,0,0));
		rigthBotCameraBorder = Camera.main.ViewportToWorldPoint(new Vector3 (1,0,0));
		
		leftTopCameraBorder = Camera.main.ViewportToWorldPoint(new Vector3 (0,1,0));
		rigthTopCameraBorder = Camera.main.ViewportToWorldPoint(new Vector3 (1,1,0));
    }

    // Update is called once per frame
    void Update(){
		siz.x = gameObject.GetComponent<SpriteRenderer>().bounds.size.x;
		siz.y = gameObject.GetComponent<SpriteRenderer>().bounds.size.y;
		
		
		if(transform.position.y < leftBotCameraBorder.y + (siz.y / 2)){
			gameObject.transform.position = new Vector3(transform.position.x,
										leftBotCameraBorder.y + (siz.y / 2),
										transform.position.z);
		}
		
		if(transform.position.y > leftTopCameraBorder.y - (siz.y / 2)){
			gameObject.transform.position = new Vector3(transform.position.x,
										leftTopCameraBorder.y - (siz.y / 2),
										transform.position.z);
		}

		if(transform.position.x < leftTopCameraBorder.x + (siz.x / 2)){
			gameObject.transform.position = new Vector3(leftTopCameraBorder.x + (siz.x / 2),
										transform.position.y,
										transform.position.z);
		}
		
		if(transform.position.x > rigthBotCameraBorder.x - (siz.x / 2)){
			gameObject.transform.position = new Vector3(rigthBotCameraBorder.x - (siz.x / 2),
										transform.position.y,
										transform.position.z);
		}
		
		
    }
}
