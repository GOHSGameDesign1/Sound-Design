using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    public List<string> dialogueList = new List<string>();
    public int currentLineCounter;
    public string currentLine;

    public delegate void ChangeText(string currentString);
    public static event ChangeText changeText;

    // Start is called before the first frame update
    void Start()
    {
        currentLineCounter = 0;
        currentLine = dialogueList[0];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AdvanceDialogue()
    {
        if (currentLineCounter < dialogueList.Count)
        {
            changeText(dialogueList[currentLineCounter]);
            currentLineCounter++;
        }
    }

    public void setCurrentLine()
    {
        currentLine = dialogueList[currentLineCounter];
    }
}
