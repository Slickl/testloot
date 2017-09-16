using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class fight : MonoBehaviour {

    public Rigidbody2D rb2d;       //Store a reference to the Rigidbody2D component required to use 2D Physics.
    public BoxCollider2D box2d;

    public Rigidbody2D rb2dEnemy;       //Store a reference to the Rigidbody2D component required to use 2D Physics.
    public BoxCollider2D box2dEnemy;

    public Rigidbody2D rb2dShop;       //Store a reference to the Rigidbody2D component required to use 2D Physics.
    public BoxCollider2D box2dShop;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if (box2d.IsTouching(box2dEnemy))
        {
            Application.UnloadLevel("test");
            Application.LoadLevel("battle");
        }
        else if (box2d.IsTouching(box2dShop))
        {
            Application.UnloadLevel("test");
            Application.LoadLevel("shop");
        }

    }
}
