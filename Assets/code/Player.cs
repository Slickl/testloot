using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player  {

    string name;
    int maxhp, maxint;
    int cHp, cInt,att;

    public Player(string name)
    {

        this.name = name;
        this.maxhp = 10;
        this.maxint = 10;
        this.cHp = maxhp;
        this.att = 3;


    }

    // Use this for initialization
    void Start()
    {
        
    }
	// Update is called once per frame
	void Update () {
		
	}

    public void hit(int amount)
    {

        if (cHp + amount < maxhp || cHp + amount > 0)
        {
            this.cHp += amount;
        }
        else if ( cHp + amount < 0)
        {
            cHp = 0;
        }
        else
        {
            cHp = maxhp;
        }
        
    }

    public void up(int amount)
    {
        for (int i = 0; i < amount; i++)
        {

        }
        maxhp++;
        maxint++;
        {
 
        }

    }

    public int getCHp()
    {
        return this.cHp;
    }

    public int getAtt()
    {
        return this.att;
    }
}
