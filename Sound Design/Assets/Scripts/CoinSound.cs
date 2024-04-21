using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinSound : MonoBehaviour
{
    public AudioClip[] sounds;
    public AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        switch (DialogueManager.GetInstance().currentLineCounter)
        {
            case 7:
                source.clip = sounds[0]; 
                break;
            case 8:
                source.clip = sounds[0];
                break;
            case 9:
                source.clip = sounds[1];
                break;
            case 10:
                source.clip = sounds[1];
                break;
            case 11:
                source.clip = sounds[2];
                break;
            default:
                break;
        }
        source.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
