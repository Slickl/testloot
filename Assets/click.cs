using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class click : MonoBehaviour
{
    public Button b1;
   

    // Use this for initialization
    void Start()
    {
        b1.enabled = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        
        b1.onClick.AddListener(isClicked);
    }

    // Button auf A wenn click dann attack
    public void isClicked()
    {

        Application.UnloadLevel("battle");
        Application.LoadLevel("test");
        Debug.Log("You have clicked the button!");
    }
}