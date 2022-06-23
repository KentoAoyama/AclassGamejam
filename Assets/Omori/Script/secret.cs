using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class secret : MonoBehaviour
{
    [SerializeField] GameObject _button1;
    [SerializeField] GameObject _button2;
    [SerializeField] GameObject _button3;
    [SerializeField] GameObject _button4;
    // Start is called before the first frame update
    void Start()
    {
        _button2.SetActive(false);
        _button3.SetActive(false);
        _button4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Button1()
    {
        _button2.SetActive(true);
    }

    public void Button2()
    {
        _button3.SetActive(true);
    }

    public void Button3()
    {
        _button4.SetActive(true);
    }

    public void Button4()
    {
        _button1.SetActive(false);
        _button2.SetActive(false);
        _button3.SetActive(false);
        _button4.SetActive(false);
    }
}
