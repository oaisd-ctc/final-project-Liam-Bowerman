using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialScrpit : MonoBehaviour
{
    [SerializeField] private bool hasPressedW = false;
    [SerializeField] private bool hasPressedS = false;
    [SerializeField] private bool hasPressedA = false;
    [SerializeField] private bool hasPressedD = false;

    [SerializeField] private bool hasJumped = false;

    public Text tutorialText;
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            hasPressedW = true;
        }
        if (Input.GetKey(KeyCode.S))
        {
            hasPressedS = true;
        }
        if (Input.GetKey(KeyCode.A))
        {
            hasPressedA = true;
        }
        if (Input.GetKey(KeyCode.D))
        {
            hasPressedD = true;
        }

        if(hasPressedW == true && hasPressedA == true && hasPressedS == true && hasPressedD == true && hasJumped != true)
        {
            tutorialText.text = "Nice job!\nNow press Space to jump over the wall.";
            if (Input.GetKey(KeyCode.Space))
            {
                hasJumped = true;
                tutorialText.text = "Awesome, now walk to the next area.";
            }
        }
    }
}
