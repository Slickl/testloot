using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class click : MonoBehaviour
{

   

    // Use this for initialization
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        

    }

    // Button auf A wenn click dann attack
    public void isClicked()
    {

        Application.LoadLevel("test");
        Application.UnloadLevel("battle");
        Debug.Log("You have clicked the button!");
    }
}