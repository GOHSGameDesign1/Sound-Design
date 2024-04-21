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


    public static DialogueManager instance;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }

    public static DialogueManager GetInstance() { return instance; }

    // Start is called before the first frame update
    void Start()
    {
        currentLineCounter = -1;
        currentLine = dialogueList[0];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AdvanceDialogue()
    {
        if (currentLineCounter + 1 < dialogueList.Count)
        {
            currentLineCounter++;
            changeText(dialogueList[currentLineCounter]);
        }
    }

    public void setCurrentLine()
    {
        currentLine = dialogueList[currentLineCounter];
    }
}
