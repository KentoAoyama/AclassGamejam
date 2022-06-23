using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Janken : MonoBehaviour
{
    
    [SerializeField] GameObject _1gu;
    [SerializeField] GameObject _1cho;
    [SerializeField] GameObject _1pa;
    //[SerializeField] GameObject _1right;
    //[SerializeField] GameObject _1up;
    //[SerializeField] GameObject _1left;
    //[SerializeField] GameObject _1down;
    
    
    [SerializeField] GameObject _2gu;
    [SerializeField] GameObject _2cho;
    [SerializeField] GameObject _2pa;
    //[SerializeField] GameObject _2right;
    //[SerializeField] GameObject _2up;
    //[SerializeField] GameObject _2left;
    //[SerializeField] GameObject _2down;

    
    //Ç†Ç¡ÇøÇﬁÇ¢ÇƒÇŸÇ¢ÉÇÅ[ÉhÇÃämîF
    public static bool _amh;

    //ÇPPÇ∂Ç·ÇÒÇØÇÒ
    bool _1g;
    bool _1c;
    bool _1p;
    //1PÇ†Ç¡Çø
    //bool _1L;
    //bool _1U;
    //bool _1R;
    //bool _1D;


    //ÇQPÇ∂Ç·ÇÒÇØÇÒ
    bool _2g;
    bool _2c;
    bool _2p;
    //2PÇ†Ç¡Çø
    //bool _2L;
    //bool _2U;
    //bool _2R;
    //bool _2D;


    //èüîsÇÃîªíf
    bool _1Pwin;
    bool _2Pwin;


    GameObject _1Pdefault;
    GameObject _2Pdefault;

    GameObject _1P;
    GameObject _2P;

    void OnEnbled()
    {
        _amh = false;
        
        _1P = GameObject.FindWithTag("Player1");
        _2P = GameObject.FindWithTag("Player2");
    }

    void FixedUpdate()
    {
        if (_amh == false)
        {
            JankenSystem(KeyCode.A, _1g);
            JankenSystem(KeyCode.S, _1c);
            JankenSystem(KeyCode.D, _1p);


            JankenSystem(KeyCode.LeftArrow, _2g);
            JankenSystem(KeyCode.DownArrow, _2c);
            JankenSystem(KeyCode.RightArrow, _2p);
        }
        
        
        //AmhSystem(KeyCode.A, _1L);
        //AmhSystem(KeyCode.W, _1U);
        //AmhSystem(KeyCode.S, _1R);
        //AmhSystem(KeyCode.D, _1D);

        //AmhSystem(KeyCode.LeftArrow, _2L);
        //AmhSystem(KeyCode.UpArrow, _2U);
        //AmhSystem(KeyCode.RightArrow, _2R);
        //AmhSystem(KeyCode.DownArrow, _2D);


        if (_1g == true) _1gu.SetActive(true);
        if (_1c == true) _1cho.SetActive(true);
        if (_1p == true) _1pa.SetActive(true);
        
        if (_2g == true) _2gu.SetActive(true);
        if (_2c == true) _2cho.SetActive(true);
        if (_2p == true) _2pa.SetActive(true);

        if (_1g == false) _1gu.SetActive(false);
        if (_1c == false) _1cho.SetActive(false);
        if (_1p == false) _1pa.SetActive(false);

        if (_2g == false) _2gu.SetActive(false);
        if (_2c == false) _2cho.SetActive(false);
        if (_2p == false) _2pa.SetActive(false);
    }


    void Update()
    {
        if (_1gu.activeSelf == false || _1cho.activeSelf == false || _1pa.activeSelf == false ||
            _2gu.activeSelf == false || _2cho.activeSelf == false || _2pa.activeSelf == false)
        {
            if (_1g == true && _2g == true)
            {
                _1g = false;
                _2g = false;
            }
            if (_1g == true && _2c == true)
            {
                _1g = false;
                _2c = false;

                GameManeger._1pWinCount += 1;
            }
            if (_1g == true && _2p == true)
            {
                _1g = false;
                _2p = false;

                GameManeger._2pWinCount += 1;
            }
            

            if (_1c == true && _2g == true)
            {
                _1c = false;
                _2g = false;

                GameManeger._2pWinCount += 1;
            }
            if (_1c == true && _2c == true)
            {
                _1c = false;
                _2c = false;
            }
            if (_1c == true && _2p == true)
            {
                _1c = false;
                _2p = false;

                GameManeger._1pWinCount += 1;
            }


            if (_1p == true && _2g == true)
            {
                _1p = false;
                _2g = false;

                GameManeger._1pWinCount += 1;
            }
            if (_1p == true && _2c == true)
            {
                _1p = false;
                _2c = false;

                GameManeger._2pWinCount += 1;
            }
            if (_1p == true && _2p == true)
            {
                _1p = false;
                _2p = false;
            }

        }
    }


    void JankenSystem(KeyCode x, bool a)
    {
        if (Input.GetKeyDown(x) && _amh == false)
        {
            Button(a);
        }
    }

    void  Button(bool a)
    {
        if (a == false)
        {
            a = true;
        }
    }
    
    //void AmhSystem(KeyCode j, bool a)
    //{
    //    if (Input.GetKeyDown(j) && _amh == true)
    //    {
    //        Button(a);
    //    }
    //}
}
