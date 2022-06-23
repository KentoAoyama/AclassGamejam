using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defend1 : MonoBehaviour
{
    public bool _okdefend1 = false;
    [SerializeField] AMT_Manager _amt;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if(_amt._startgame_p1_Defend)
        {
            Defend();
        }

    }

    void Defend()
    {

        if (Input.GetKeyDown("w"))
        {
            Debug.Log("w");
            _okdefend1 = true;
            _amt.p1_defend = "Up";
        }
        if (Input.GetKeyDown("d"))
        {
            _okdefend1 = true;
            _amt.p1_defend = "Right";
        }
        if (Input.GetKeyDown("a"))
        {
            _okdefend1 = true;
            _amt.p1_defend = "Left";
        }
        if (Input.GetKeyDown("s"))
        {
            _okdefend1 = true;
            _amt.p1_defend = "Down";
        }
    }

}
