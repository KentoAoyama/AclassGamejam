using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    [SerializeField] AudioSource _audio;
    // Start is called before the first frame update
    void Start()
    {
        _audio.volume = audioController._hikitugi;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
