using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class click : MonoBehaviour
{

    FightCpu cpu;


    void Start()
    {
       
    }

    void Update()
    {
        Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(pos, Vector2.zero);
        if (hit != null && hit.collider != null && Input.GetButtonDown("Fire1"))
        {
            Debug.Log("I'm hitting " + hit.collider.name);
            AttackClicked();
            
        }
    }

    public void AttackClicked()
    {
        cpu = new FightCpu();
        cpu.AttackTrigger();




    }
}

