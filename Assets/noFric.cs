using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class noFric : MonoBehaviour {

    private BoxCollider2D box2d;

	// Use this for initialization
	void Start () {

        box2d = GetComponent<BoxCollider2D>();
        box2d.sharedMaterial.friction = 0.0f;
        box2d.enabled = false;
        box2d.enabled = true;

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
