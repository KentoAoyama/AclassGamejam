using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount1 : MonoBehaviour
{
    [SerializeField]  Image _Score1;
    [SerializeField]  Image _Score2;
    [SerializeField]  float _maxScore;

    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
       

        if(GameManager._1pWinCount == 3)
        {
           _Score2.fillAmount = 1f;
        }
        else if (GameManager._1pWinCount == 2)
        {
            _Score2.fillAmount = 0.66f;
        }
       
      else  if(GameManager._1pWinCount == 1)
        {
          _Score2.fillAmount = 0.33f;

        }
       else if(GameManager._1pWinCount == 0)
        {
            
_Score2.fillAmount = 0;
        }
       
      
      
         if (GameManager._2pWinCount == 3)
        {
            
 _Score1.fillAmount = 1f;
        }
         else if (GameManager._2pWinCount == 2)
        {
            
_Score1.fillAmount = 0.66f;
        }
        
       else if (GameManager._2pWinCount == 1)
        {
            
  _Score1.fillAmount = 0.33f;
        }
      else  if (GameManager._2pWinCount == 0)
        {
            
_Score1.fillAmount = 0;
        }
    }


    void AAA()
    {



    }

    //public void UpdateScore(float change)
    //{
    //    if (GameManager._1pWinCount <= _maxScore)
    //    {
    //        _currentScore = Mathf.Clamp(_currentScore + change, 0, _maxScore);
    //        _Score.fillAmount = _currentScore / _maxScore;
    //    }

    //    else if (GameManager._2pWinCount <= _maxScore)
    //    {
    //        _currentScore = Mathf.Clamp(_currentScore + change, 0, _maxScore);
    //        _Score.fillAmount = _currentScore / _maxScore;
    //    }
    //}
}
