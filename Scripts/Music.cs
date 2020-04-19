using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[RequireComponent(typeof(AudioSource))]
public class Music : MonoBehaviour
{

    [SerializeField]
    private AudioSource myMusic;

    // Start is called before the first frame update
    void Awake()
    {
        myMusic = GetComponent<AudioSource>();

        myMusic.Play();

        DontDestroyOnLoad(this.gameObject);

    }

    
}
