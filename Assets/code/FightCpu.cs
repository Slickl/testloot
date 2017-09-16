using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class FightCpu {
    public Player player;
    public Enemy enemy;

    public FightCpu()
    {


        Player player = new Player();
     
        Enemy enemy = new Enemy("testhunt");

        this.enemy = enemy;
        this.player = player;
    }


    public void AttackTrigger()
    {
        while (player.getCHp() > 0 && enemy.getCHp() > 0 )
        {
            player.hit(enemy.getAtt() * -1);
            enemy.hit(player.getAtt() * -1);
            Debug.Log("player " + player.getCHp());
            Debug.Log("Enemy " + enemy.getCHp());
        }


        if (player.getCHp() <= 0)
        {
            
            Application.UnloadLevel("battle");
            Application.LoadLevel("Hauptmenü");


        }
        else if (enemy.getCHp() <= 0)
        {
            Application.UnloadLevel("battle");
            Application.LoadLevel("test");
            player.setPoints(player.getPoints() + 1);

            using (StreamWriter writer =
          new StreamWriter(@"D:\" +player.getName() + ".acc"))
            {
                writer.WriteLine(player.getName());
                writer.WriteLine(player.getMaxHp());
                writer.WriteLine(player.getCHp());
                writer.WriteLine(player.getMaxInt());
                writer.WriteLine(player.getCInt());
                writer.WriteLine(player.getAtt());
                writer.WriteLine(player.getPoints());
            }
        }
        {

        }
    }
}
