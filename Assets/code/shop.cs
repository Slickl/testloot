﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shop : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        SwitchMap();

    }

    void SwitchMap()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Application.LoadLevel("test");
            Application.UnloadLevel("Hauptmenü");
        }
    }


}
