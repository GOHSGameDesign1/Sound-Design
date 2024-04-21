using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Ogre : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (checkForHit())
            {
                AudioManager.GetInstance().Play("Punch");
                transform.rotation = Quaternion.Euler(0, 0, -12f * Mathf.Sign(transform.rotation.z));
                playGrunt();
            }
        }
    }

    bool checkForHit()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit2D hit = Physics2D.GetRayIntersection(ray);

        if (hit)
        {
            return true;
        } else
        {
            return false;
        }
    }

    void playGrunt()
    {
        AudioManager instance = AudioManager.GetInstance();
        switch (DialogueManager.GetInstance().currentLineCounter)
        {
            case 13:
                instance.Play("Ogre Grunt 1");
                break;
            case 14:
                instance.Play("Ogre Grunt 1");
                break;
            case 15:
                instance.Play("Ogre Grunt " + Random.Range(1, 4));
                break;
            case 16:
                instance.Play("Ogre Grunt " + Random.Range(1, 4));
                break;
            case 17:
                instance.Play("Ogre Grunt " + Random.Range(1, 4));
                break;
            default:
                break;
        }
    }
}
