using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] Text _score = default;
    [SerializeField] Text _winner = default;
    [SerializeField] Text _kimarite = default;

    [SerializeField] float _distance;
    [SerializeField] int _maxSize;

    [SerializeField] string[] _kimariteWord;

    float _timer = default;
    // Start is called before the first frame update
    void Start()
    {
        _score.text = $"1P {GameManager._1pWinCount} - {GameManager._2pWinCount} 2P";
        if (GameManager._1pWinner)
        {
            _winner.text = "1P Win!!";
        }
        else if (GameManager._2pWinner)
        {
            _winner.text = "2P Win!!";
        }

        for(int i = 0; i < 3; i++)
        {
            if (GameManager._1pWinCount == 3 && GameManager._2pWinCount == i)
            {
                _kimarite.text = $"Œˆ‚Ü‚èŽèF{_kimariteWord[i]}";
            }
        }
        for (int i = 0; i < 3; i++)
        {
            if (GameManager._1pWinCount == i && GameManager._2pWinCount == 3)
            {
                _kimarite.text = $"Œˆ‚Ü‚èŽèF{_kimariteWord[i]}";
            }
        }

        

        _winner.fontSize = 0;
    }

    // Update is called once per frame
    void Update()
    {
        _timer += Time.deltaTime;
        if (_timer > _distance && _winner.fontSize < _maxSize)
        {
            _winner.fontSize += 1;
            _timer = 0;
        }
    }

    
}
