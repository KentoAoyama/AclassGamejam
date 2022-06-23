using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class audioController : MonoBehaviour
{
    [SerializeField] Slider _slider;
    [SerializeField] AudioSource _volume;
    public static float _hikitugi;
    [SerializeField] GameObject _Gslider;
    // Start is called before the first frame update
    void Start()
    {
        _Gslider.SetActive(false);       
    }

    // Update is called once per frame
    void Update()
    {
        _hikitugi = _slider.value;
        _volume.volume = _hikitugi;       
    }

    public void Opensettei()
    {
        _Gslider.SetActive(true);
    }

    public void Closesettei()
    {
        _Gslider.SetActive(false);
    }
}
