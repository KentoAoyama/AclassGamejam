using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class AMT_Manager : MonoBehaviour
{

    public bool _startgame_p1_Attack=false;     //P1が指
    public bool _startgame_p1_Defend = false;    //P１が顔

    public bool _next_attack1=false;
    public bool _next_defend1=false;


    public int win1;　//勝敗
    public int win2;//勝敗

    public string p1_attack;　　//向いた方向
    public string p1_defend;    //向いた方向

    public string p2_attack;    //向いた方向
    public string p2_defend;    //向いた方向


    [SerializeField] Attack1 _attack1;    //スクリプトゲット
    [SerializeField] Defend1 _defend1;


    [SerializeField] Defend2 _defend2;    //スクリプトゲット
    [SerializeField] Attack2 _attack2;


    [SerializeField] GameObject Defolt_Face1;
    [SerializeField] GameObject Defolt_Face2;

    [SerializeField] GameObject Defolt_Yubi1;
    [SerializeField] GameObject Defolt_Yubi2;

    [SerializeField]  GameObject   Ue_Yubi_1;
    [SerializeField]  GameObject   Sita_Yubi_1;
    [SerializeField]  GameObject   Migi_Yubi_1;
    [SerializeField]  GameObject   Hidari_Yubi_1;

    [SerializeField] GameObject Ue_Face_1;
    [SerializeField] GameObject Sita_Face_1;
    [SerializeField] GameObject Migi_Face_1;
    [SerializeField] GameObject Hidari_Face_1;

    [SerializeField] GameObject Ue_Yubi_2;
    [SerializeField] GameObject Sita_Yubi_2;
    [SerializeField] GameObject Migi_Yubi_2;
    [SerializeField] GameObject Hidari_Yubi_2;

    [SerializeField] GameObject Ue_Face_2;
    [SerializeField] GameObject Sita_Face_2;
    [SerializeField] GameObject Migi_Face_2;
    [SerializeField] GameObject Hidari_Face_2;

    [SerializeField] Text _text;

    [SerializeField] GameObject _janken;
    [SerializeField] Janken _jan;


    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(_next_attack1)   //P1が指
        {
            Defolt_Face2.SetActive(true);
            Defolt_Yubi1.SetActive(true);

            _startgame_p1_Attack = true;
             _next_attack1 = false;
            _janken.SetActive(false);
        }


        if (_next_defend1)　//P1が顔
        {
            Defolt_Face1.SetActive(true);
            Defolt_Yubi2.SetActive(true);
            _startgame_p1_Defend = true;
            _next_defend1 = false;

            _janken.SetActive(false);
        }





        if (_defend2._okdefend2&&_attack1._okattack1)　//どっちも入力したら判定
        {
            Defolt_Face2.SetActive(false);
            Defolt_Yubi1.SetActive(false);
            JudgeAttack1();
        }

        if (_defend1._okdefend1 && _attack2._okattack2)　//どっちも入力したら判定
        {
            Defolt_Face1.SetActive(false);
            Defolt_Yubi2.SetActive(false);
            JudgeDefend1();
        }

    }

    public void JudgeDefend1()  //
    {
        if (p2_attack == "Up" && p1_defend == "Up")
        {
            Ue_Yubi_2.SetActive(true);
            Ue_Face_1.SetActive(true);
            GameManager._2pWinCount++;
            _startgame_p1_Defend = false;
            Invoke("ResetKey", 2);
            _text.text = "Player2の勝ち";
            StartCoroutine(Next());
        }
        else if (p2_attack == "Right" && p1_defend == "Right")
        {
            Migi_Yubi_2.SetActive(true);
            Migi_Face_1.SetActive(true);
            GameManager._2pWinCount++;
            _startgame_p1_Defend = false;
            _text.text = "Player2の勝ち";

            Invoke("ResetKey", 2);
            StartCoroutine(Next());
        }
        else if (p2_attack == "Left" && p1_defend == "Left")
        {
            Hidari_Yubi_2.SetActive(true);
            Hidari_Face_1.SetActive(true);
            GameManager._2pWinCount++;
            _startgame_p1_Defend = false;
            _text.text = "Player2の勝ち";
            Invoke("ResetKey", 2);
            StartCoroutine(Next());
        }
        else if (p2_attack == "Down" && p1_defend == "Down")
        {
            Sita_Yubi_2.SetActive(true);
            Sita_Face_1.SetActive(true);
            GameManager._2pWinCount++;
            _startgame_p1_Defend = false;
            _text.text = "Player2の勝ち";
            Invoke("ResetKey", 2);
            StartCoroutine(Next());
        }
        else if(p2_attack!=p1_defend)
        {
            Gazo2Attack();
            Gazo1Defend();
            _startgame_p1_Defend = false;
            _text.text = "One More Janken";
            ResetKey();
            StartCoroutine(Next());
        }

    }


    public void JudgeAttack1()  //判定
    {

        if(p1_attack=="Up"&&p2_defend=="Up")
        {
            Ue_Yubi_1.SetActive(true);
            Ue_Face_2.SetActive(true);
            GameManager._1pWinCount++;
            _startgame_p1_Attack = false;
            Invoke("ResetKey", 2);
            _text.text = "Player1の勝ち";
            StartCoroutine(Next());
        }
          else if (p1_attack == "Right" && p2_defend == "Right")
        {
            Migi_Yubi_1.SetActive(true);
            Migi_Face_2.SetActive(true);
            GameManager._1pWinCount++;
            _startgame_p1_Attack = false;
            Invoke("ResetKey", 2);
            _text.text = "Player1の勝ち";
            StartCoroutine(Next());
        }
          else if (p1_attack == "Left" && p2_defend == "Left")
        {
            Hidari_Yubi_1.SetActive(true);
            Hidari_Face_2.SetActive(true);
            GameManager._1pWinCount++;
            _startgame_p1_Attack = false;
            Invoke("ResetKey", 2);
            _text.text = "Player1の勝ち";
            StartCoroutine(Next());
        }
          else if (p1_attack == "Down" && p2_defend == "Down")
        {
            Sita_Yubi_1.SetActive(true);
            Sita_Face_2.SetActive(true);
            GameManager._1pWinCount++;
            _startgame_p1_Attack = false;
            Invoke("ResetKey", 2);
           // _janken.SetActive(true);
            _text.text = "Player1の勝ち";
            StartCoroutine(Next()); ;

        }
            else if (p1_attack != p2_defend)
        {
            Gazo1Attack();
            Gazo2Defend();
            _startgame_p1_Attack = false;
            _text.text = "One More Janken";
            ResetKey();
            StartCoroutine(Next());
        }


    }

    void Gazo1Defend()
    {
        if (p1_defend == "Up")
        {
            Ue_Face_1.SetActive(true);
        }
        else if (p1_defend == "Right")
        {
            Migi_Face_1.SetActive(true);
        }
        else if (p1_defend == "Left")
        {
            Hidari_Face_1.SetActive(true);
        }
        else if(p1_defend == "Down")
        {
            Sita_Face_1.SetActive(true);
        }
    }
    void Gazo2Defend()
    {
        if (p2_defend == "Up")
        {
            Ue_Face_2.SetActive(true);
        }
        else if (p2_defend == "Right")
        {
            Migi_Face_2.SetActive(true);
        }
        else if (p2_defend == "Left")
        {
            Hidari_Face_2.SetActive(true);
        }
        else if (p2_defend == "Down")
        {
            Sita_Face_1.SetActive(true);
        }
    }


    void Gazo1Attack()
    {
        if(p1_attack == "Up")
        {
            Ue_Yubi_1.SetActive(true);
        }
        else if(p1_attack == "Right")
        {
            Migi_Yubi_1.SetActive(true);
        }
        else if(p1_attack == "Left")
        {
            Hidari_Yubi_1.SetActive(true);
        }
        else if(p1_attack == "Down")
        {
            Sita_Yubi_1.SetActive(true);
        }
    }
    void Gazo2Attack()
    {
        if (p2_attack == "Up")
        {
            Ue_Yubi_2.SetActive(true);
        }
        else if (p2_attack == "Right")
        {
            Migi_Yubi_2.SetActive(true);
        }
        else if (p2_attack == "Left")
        {
            Hidari_Yubi_2.SetActive(true);
        }
        else if (p2_attack == "Down")
        {
            Sita_Yubi_2.SetActive(true);
        }
    }



    void ResetKey()
    {


        p1_attack = null;
        p1_defend = null;
        p2_attack = null;
        p2_defend = null;

        _attack1._okattack1 = false;
        _attack2._okattack2 = false;
        _defend1._okdefend1 = false;
        _defend2._okdefend2 = false;
    }


    IEnumerator Next()
    {
        yield return new WaitForSeconds(5);

        Ue_Yubi_1.SetActive(false);
        Sita_Yubi_1.SetActive(false);
        Migi_Yubi_1.SetActive(false);
        Hidari_Yubi_1.SetActive(false);

        Ue_Face_1.SetActive(false);
        Migi_Face_1.SetActive(false);
        Hidari_Face_1.SetActive(false);
        Sita_Face_1.SetActive(false);

        Ue_Yubi_2.SetActive(false);
        Sita_Yubi_2.SetActive(false);
        Migi_Yubi_2.SetActive(false);
        Hidari_Yubi_2.SetActive(false);

        Ue_Face_2.SetActive(false);
        Migi_Face_2.SetActive(false);
        Hidari_Face_2.SetActive(false);
        Sita_Face_2.SetActive(false);

        GameManager._amh = true;
        _janken.SetActive(true);
        this.gameObject.SetActive(false);

        _text.text = null;
    }

}
