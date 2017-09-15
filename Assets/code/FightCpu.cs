using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightCpu {

    Player player = new Player("testloot");
    Enemy enemy = new Enemy("testhunt");

    public void AttackTrigger()
    {
        player.hit(enemy.getAtt() * -1);
        enemy.hit(player.getAtt()* -1);
        Debug.Log("player " + player.getCHp());
        Debug.Log("Enemy " + enemy.getCHp());

        if (player.getCHp() <= 0)
        {

            Application.UnloadLevel("battle");
            Application.LoadLevel("Hauptmenü");


        }
        else if (enemy.getCHp() <= 0)
        {
            Application.UnloadLevel("battle");
            Application.LoadLevel("test");
        }
        {

        }
    }
}
