using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Janken : MonoBehaviour
{
    
    [SerializeField] Sprite _gu;
    [SerializeField] Sprite _cho;
    [SerializeField] Sprite _pa;
    [SerializeField] Sprite _right;
    [SerializeField] Sprite _up;
    [SerializeField] Sprite _left;
    [SerializeField] Sprite _down;

    //Ç†Ç¡ÇøÇﬁÇ¢ÇƒÇŸÇ¢ÉÇÅ[ÉhÇÃämîF
    public static bool _amh;

    //ÇPPÇ∂Ç·ÇÒÇØÇÒ
    bool _1g;
    bool _1c;
    bool _1p;
    //1PÇ†Ç¡Çø
    bool _1L;
    bool _1U;
    bool _1R;
    bool _1D;


    //ÇQPÇ∂Ç·ÇÒÇØÇÒ
    bool _2g;
    bool _2c;
    bool _2p;
    //2PÇ†Ç¡Çø
    bool _2L;
    bool _2U;
    bool _2R;
    bool _2D;


    //èüîsÇÃîªíf
    bool _1Pwin;
    bool _2Pwin;


    SpriteRenderer _1Psr;
    SpriteRenderer _2Psr;

    Sprite _1Pdefault;
    Sprite _2Pdefault;

    GameObject _1P;
    GameObject _2P;

    void OnEnbled()
    {
        _amh = false;
        
        _1P = GameObject.FindWithTag("Player1");
        _2P = GameObject.FindWithTag("Player2");
        _1Psr = GetComponent<SpriteRenderer>();
        _2Psr = GetComponent<SpriteRenderer>();

        _1Psr.sprite = _1Pdefault;
        _2Psr.sprite = _2Pdefault;
    }

    void FixedUpdate()
    {
        JankenSystem(KeyCode.A, _1g);
        JankenSystem(KeyCode.S, _1c);
        JankenSystem(KeyCode.D, _1p);

        JankenSystem(KeyCode.LeftArrow, _2g);
        JankenSystem(KeyCode.DownArrow, _2c);
        JankenSystem(KeyCode.RightArrow, _2p);
        
        
        AmhSystem(KeyCode.A, _1L);
        AmhSystem(KeyCode.W, _1U);
        AmhSystem(KeyCode.S, _1R);
        AmhSystem(KeyCode.D, _1D);

        AmhSystem(KeyCode.LeftArrow, _2L);
        AmhSystem(KeyCode.UpArrow, _2U);
        AmhSystem(KeyCode.RightArrow, _2R);
        AmhSystem(KeyCode.DownArrow, _2D);
    }


    void Update()
    {
        if (_1Psr.sprite == null || _1Psr.sprite == null)
        {
            if (_1g == true && _2g == true)
            {
                
            }
            if (_1g == true && _2c == true)
            {

            }
            if (_1g == true && _2p == true)
            {

            }
            

            if (_1c == true && _2g == true)
            {

            }
            if (_1c == true && _2c == true)
            {

            }
            if (_1c == true && _2p == true)
            {

            }


            if (_1p == true && _2g == true)
            {

            }
            if (_1p == true && _2c == true)
            {

            }
            if (_1p == true && _2p == true)
            {

            }

        }
    }

    void JankenBattle(bool _1P, bool _2P)
    {
        
    }

    void JankenSystem(KeyCode x, bool a)
    {
        if (Input.GetKeyDown(x) && _amh == false)
        {
            A(a);
        }
    }

    void AmhSystem(KeyCode j, bool a)
    {
        if (Input.GetKeyDown(j) && _amh == true)
        {
            A(a);
        }
    }


    void  A(bool a)
    {
        if (a == false)
        {
            a = true;
        }
    }
}
