using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForestDemo : MonoBehaviour
{
    GameObject jumpscareBanana;
    private void Awake()
    {
        jumpscareBanana = transform.GetChild(1).gameObject;
        jumpscareBanana.SetActive(false);
    }

    private void OnEnable()
    {
        DialogueManager.changeText += changeStuff;
        AudioManager.GetInstance().Play("Night Forest");
        AudioManager.GetInstance().Play("Scary Ambiance");
    }

    private void OnDisable()
    {
        DialogueManager.changeText -= changeStuff;
    }

    private void changeStuff(string currentLine)
    {
        AudioManager instance = AudioManager.GetInstance();
        switch (DialogueManager.GetInstance().currentLineCounter)
        {
            case 20:
                instance.Play("Breathing");
                break;
            case 22:
                instance.Stop("Night Forest");
                instance.Stop("Scary Ambiance");
                break;
            case 24:
                instance.Play("Jumpscare");
                jumpscareBanana.SetActive(true);
                instance.Stop("Breathing");
                break;
            default:
                break;
        }
    }
}
