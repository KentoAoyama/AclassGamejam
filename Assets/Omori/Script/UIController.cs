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
        _score.text = $"1P {GameManeger._1pWinCount} - {GameManeger._2pWinCount} 2P";
        if (GameManeger._1pWinner)
        {
            _winner.text = "1P Win!!";
        }
        else if (GameManeger._2pWinner)
        {
            _winner.text = "2P Win!!";
        }

        for(int i = 0; i < 3; i++)
        {
            if (GameManeger._1pWinCount == 3 && GameManeger._2pWinCount == i)
            {
                _kimarite.text = $"Œˆ‚Ü‚èŽèF{_kimariteWord[i]}";
            }
        }
        for (int i = 0; i < 3; i++)
        {
            if (GameManeger._1pWinCount == i && GameManeger._2pWinCount == 3)
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
