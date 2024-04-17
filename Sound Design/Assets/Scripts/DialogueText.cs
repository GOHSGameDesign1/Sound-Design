using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueText : MonoBehaviour
{
    public TextMeshProUGUI textMeshProUGUI;

    private void OnEnable()
    {
        DialogueManager.changeText += showText;
    }

    private void OnDisable()
    {
        DialogueManager.changeText -= showText;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void showText(string currentString)
    {
        textMeshProUGUI.text = currentString;
    }
}
