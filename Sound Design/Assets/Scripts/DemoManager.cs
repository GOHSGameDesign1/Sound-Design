using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemoManager : MonoBehaviour
{
    public GameObject platformerDemo;

    // Start is called before the first frame update
    void Start()
    {
        platformerDemo.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        int counter = DialogueManager.GetInstance().currentLineCounter;

        switch (counter)
        {
            case 4:
                platformerDemo.SetActive(true);
                break;
            default:
                break;
        }
    }
}
