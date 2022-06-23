using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack2 : MonoBehaviour
{

    public bool _okattack2 = false;


    [SerializeField] AMT_Manager _amt;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (_amt._startgame_p1_Defend)
        {
            Attack();
        }

    }

    void Attack()
    {

        if (Input.GetKeyDown("i"))
        {
            Debug.Log("i");
            _okattack2 = true;
            _amt.p2_attack = "Up";
        }
        if (Input.GetKeyDown("l"))
        {
            _okattack2 = true;
            _amt.p2_attack = "Right";
        }
        if (Input.GetKeyDown("j"))
        {
            _okattack2 = true;
            _amt.p2_attack = "Left";
        }
        if (Input.GetKeyDown("k"))
        {
            _okattack2 = true;
            _amt.p2_attack = "Down";
        }
    }

}
