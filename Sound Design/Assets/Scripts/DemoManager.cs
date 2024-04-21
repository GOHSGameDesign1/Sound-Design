using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoManager : MonoBehaviour
{
    public GameObject platformerDemo;
    public GameObject ogreDemo;
    public GameObject forestDemo;

    private void OnEnable()
    {
        DialogueManager.changeText += onChangeLine;
    }

    private void OnDisable()
    {
        DialogueManager.changeText -= onChangeLine;
    }

    // Start is called before the first frame update
    void Start()
    {
        platformerDemo.SetActive(false);
        ogreDemo.SetActive(false);
        forestDemo.SetActive(false);
    }

    // Update is called once per frame
    void onChangeLine(string currentLine)
    {
        int counter = DialogueManager.GetInstance().currentLineCounter;

        switch (counter)
        {
            case 4:
                platformerDemo.SetActive(true);
                break;
            case 12:
                platformerDemo.SetActive(false);
                break;
            case 13:
                ogreDemo.SetActive(true);
                break;
            case 18:
                ogreDemo.SetActive(false);
                AudioManager.GetInstance().Stop("Explain Music");
                forestDemo.SetActive(true);
                break;
            case 25:
                AudioManager.GetInstance().Play("Explain Music");
                forestDemo.SetActive(false);
                break;
            default:
                break;
        }
    }
}
