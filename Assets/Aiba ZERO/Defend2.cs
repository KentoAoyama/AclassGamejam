using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defend2 : MonoBehaviour
{


    public bool _okdefend2=false;


    [SerializeField] AMT_Manager _amt;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_amt._startgame_p1_Attack)
        {
            Defend();
        }
    }



    void Defend()
    {

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            _okdefend2 = true;
            _amt.p2_defend = "Up";
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            _okdefend2 = true;
            _amt.p2_defend = "Right";
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            _okdefend2 = true;
            _amt.p2_defend = "Left";
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            _okdefend2 = true;
            _amt.p2_defend = "Down";
        }
    }


}
