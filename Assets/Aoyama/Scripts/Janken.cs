using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Janken : MonoBehaviour
{
    
    [SerializeField] GameObject _1gu;
    [SerializeField] GameObject _1cho;
    [SerializeField] GameObject _1pa;
    
    
    [SerializeField] GameObject _2gu;
    [SerializeField] GameObject _2cho;
    [SerializeField] GameObject _2pa;

    

    //‚PP‚¶‚á‚ñ‚¯‚ñ
    bool _1g;
    bool _1c;
    bool _1p;


    //‚QP‚¶‚á‚ñ‚¯‚ñ
    bool _2g;
    bool _2c;
    bool _2p;

    bool _1pWin;
    bool _2pWin;

    bool _1sellected
    {
        get 
        {
            return _1g || _1c || _1p;
        }
    }

    bool _2sellected
    {
        get
        {
            return _2g || _2c || _2p;
        }
    }


    void OnEnable()
    {
        GameManager._amh = false;

       _1gu.SetActive(false);
       _1cho.SetActive(false);
       _1pa.SetActive(false);

       _2gu.SetActive(false);
       _2cho.SetActive(false);
       _2pa.SetActive(false);
    }

    void Update()
    {
        if (!_1sellected)
        {
            JankenSystem(KeyCode.A, ref _1g);
            JankenSystem(KeyCode.S, ref _1c);
            JankenSystem(KeyCode.D, ref _1p);
        }


        if (!_2sellected)
        {
            JankenSystem(KeyCode.LeftArrow, ref _2g);
            JankenSystem(KeyCode.DownArrow, ref _2c);
            JankenSystem(KeyCode.RightArrow, ref _2p);
        }


        if (_1pWin || _2pWin)
        {
            GameManager._amh = true;
            _1pWin = false;
            _2pWin = false;
        }


        if (_1sellected && _2sellected)  //—¼•û‚ª‰Ÿ‚³‚ê‚Ä‚½‚ç
        {
            _1gu.SetActive(_1g);
            _1cho.SetActive(_1c);
            _1pa.SetActive(_1p);

            _2gu.SetActive(_2g);
            _2cho.SetActive(_2c);
            _2pa.SetActive(_2p);
        }

  
            if (_1g == true && _2g == true)
            {
                _1g = false;
                _2g = false;

                Invoke("DestroyHands", 0.5f);
            }
            if (_1g == true && _2c == true)
            {
                _1g = false;
                _2c = false;

                _1pWin = true;

                Invoke("DestroyHands", 0.5f);
            }
            if (_1g == true && _2p == true)
            {
                _1g = false;
                _2p = false;

                _2pWin = true;

                Invoke("DestroyHands", 0.5f);
            }
            

            if (_1c == true && _2g == true)
            {
                _1c = false;
                _2g = false;

                _2pWin = true;

                Invoke("DestroyHands", 0.5f);
            }
            if (_1c == true && _2c == true)
            {
                _1c = false;
                _2c = false;

                Invoke("DestroyHands", 0.5f);
            }
            if (_1c == true && _2p == true)
            {
                _1c = false;
                _2p = false;

                _1pWin = true;
             Invoke("DestroyHands", 0.5f);
            }


            if (_1p == true && _2g == true)
            {
                _1p = false;
                _2g = false;

                _1pWin = true;
                
                Invoke("DestroyHands", 0.5f);
            }
            if (_1p == true && _2c == true)
            {
                _1p = false;
                _2c = false;

                _2pWin = true;

                Invoke("DestroyHands", 0.5f);
            }
            if (_1p == true && _2p == true)
            {
                _1p = false;
                _2p = false;

             Invoke("DestroyHands", 0.5f);
            }
    }


    void JankenSystem(KeyCode x,ref bool a)
    {
        if (Input.GetKeyDown(x) && GameManager._amh == false)
        {
            a = true;
            Debug.Log("ƒ{ƒ^ƒ“‚ª‰Ÿ‚³‚ê‚½‚æ");
        }
    }


    void DestroyHands()
    {
        _1gu.SetActive(false);
        _1cho.SetActive(false);
        _1pa.SetActive(false);

        _2gu.SetActive(false);
        _2cho.SetActive(false);
        _2pa.SetActive(false);
    }
}
