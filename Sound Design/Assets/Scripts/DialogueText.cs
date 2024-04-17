using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueText : MonoBehaviour
{
    public TextMeshProUGUI textMeshProUGUI;
    public float scrollTime;

    private void Awake()
    {
        textMeshProUGUI = GetComponent<TextMeshProUGUI>();
    }

    private void OnEnable()
    {
        DialogueManager.changeText += showText;
    }

    private void OnDisable()
    {
        DialogueManager.changeText -= showText;
    }

    void showText(string currentString)
    {
        StopAllCoroutines();
        StartCoroutine(scrollText(currentString));
    }

    IEnumerator scrollText(string line)
    {
        textMeshProUGUI.text = string.Empty;
        WaitForSeconds waitTime = new WaitForSeconds(scrollTime);
        for (int i = 0; i < line.Length; i+=2)
        {
            textMeshProUGUI.text += line[i];
            if (i + 1 < line.Length)
            {
                textMeshProUGUI.text += line[i + 1];
            }
            AudioManager.GetInstance().Play("Scroll");
            yield return waitTime;
        }
    }
}
