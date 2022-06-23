using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount1 : MonoBehaviour
{
    [SerializeField] private Image _Score;
    [SerializeField] private float _maxScore;

    // Start is called before the first frame update
    private float _currentScore;
    void Start()
    {
        _currentScore = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UpdateScore(float change)
    {
        if(GameManeger._1pWinCount <= _maxScore)
        {
            _currentScore = Mathf.Clamp(_currentScore + change, 0, _maxScore);
            _Score.fillAmount = _currentScore / _maxScore;
        }

        else if(GameManeger._2pWinCount <= _maxScore)
        {
            _currentScore = Mathf.Clamp(_currentScore + change, 0, _maxScore);
            _Score.fillAmount = _currentScore / _maxScore;
        }
    }
}
