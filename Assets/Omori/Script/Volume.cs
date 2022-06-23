using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Volume : MonoBehaviour
{
    [SerializeField] AudioSource _audioSource;
    // Start is called before the first frame update
    void Start()
    {
        _audioSource.volume = audioController._hikitugi;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
