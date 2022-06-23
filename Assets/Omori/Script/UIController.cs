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

    float _timer = default;
    // Start is called before the first frame update
    void Start()
    {
        //_score.text = $"1P{GameManager.} 
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

    void Zoom()
    {
        
    }
}
