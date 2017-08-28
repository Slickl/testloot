using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

    public float speed;             //Floating point variable to store the player's movement speed.
	
    private Rigidbody2D rb2d;       //Store a reference to the Rigidbody2D component required to use 2D Physics.
    private BoxCollider2D box2d;
    public BoxCollider2D wallR;
    public BoxCollider2D wallL;
    public BoxCollider2D wallT;
    public BoxCollider2D wallB;

    // Use this for initialization
    void Start()
    {

        rb2d = GetComponent<Rigidbody2D>();
        box2d = GetComponent<BoxCollider2D>();
        speed = 1;
        
    }

    //FixedUpdate is called at a fixed interval and is independent of frame rate. Put physics code here.
    void FixedUpdate()
    {
        //Store the current horizontal input in the float moveHorizontal.
		
        float moveHorizontal = Input.GetAxis ("Horizontal");
	
		

        //Store the current vertical input in the float moveVertical.
		
        float moveVertical = Input.GetAxis ("Vertical");
		

		
        //Use the two store floats to create a new Vector2 variable movement.
			
        Vector2 movement = new Vector2 (moveHorizontal, moveVertical);

        //check if player is toching enemy
        if (speed < 0 || speed > 0){
           
            if (box2d.IsTouchingLayers() || box2d.IsTouching(wallB) || box2d.IsTouching(wallT) || box2d.IsTouching(wallR) || box2d.IsTouching(wallL) || !Input.anyKey)
            {
                Stop();
                movement = new Vector2(moveHorizontal * -1, moveVertical * -1);
                rb2d.AddForce(movement * 10);
            }
            else
            {
                rb2d.AddForce(movement * speed);


            }
        }
    }

    void Stop()
    {
        rb2d.velocity = Vector3.zero;
        rb2d.inertia = 0f;
    }
}