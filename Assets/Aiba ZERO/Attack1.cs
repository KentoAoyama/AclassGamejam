using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack1 : MonoBehaviour
{
    //[SerializeField] GameObject[] _yubi = new GameObject[4];



    public bool _okattack1=false;


    [SerializeField] AMT_Manager _amt;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
     if(_amt._startgame_p1_Attack)
        {
            Attack();
        }

    }

    void Attack()
    {
        
        if(Input.GetKeyDown("w"))
        {
            _okattack1 = true;
            _amt.p1_attack = "Up";
        }
        if (Input.GetKeyDown("d"))
        {
            _okattack1 = true;
            _amt.p1_attack = "Right";
        }
        if (Input.GetKeyDown("a"))
        {
            _okattack1 = true;
            _amt.p1_attack = "Left";
        }
        if (Input.GetKeyDown("s"))
        {
            _okattack1 = true;
            _amt.p1_attack = "Down";
        }
    }


}


