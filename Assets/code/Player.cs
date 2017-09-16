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
        this.cInt = maxint;
        this.att = 3;


    }

    public Player(string[] stats)
    {

        this.name = stats[0].ToString();
        this.maxhp = System.Int32.Parse(stats[1].ToString());
        this.cHp = System.Int32.Parse(stats[2].ToString());
        this.maxint = System.Int32.Parse(stats[3].ToString());
        this.cInt = System.Int32.Parse(stats[4].ToString()); 
        this.att = System.Int32.Parse(stats[5].ToString()); 


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

    public string getName()
    {
        return this.name;
    }

    public int getMaxHp()
    {
        return this.maxhp;
    }

    public int getMaxInt()
    {
        return this.maxint;
    }
    public int getCInt()
    {
        return this.cInt;
    }
    
}
