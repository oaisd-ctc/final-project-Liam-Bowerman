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

    public bool hasWalkedIntoNewArea = false;
    private int numberForTutorialWall = 0;

    public bool hasClimbedLadder = false;
    public bool hasPassedHouse = false;

    public bool hasWalkedThroughEPOne = false;

    public float timer = 0f;
    private float waitTime = 200.0f;

    [SerializeField] private bool hasSprinted = false;

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
        if(hasWalkedIntoNewArea == true && numberForTutorialWall <= 0)
        {
            tutorialText.text = "Good job! \nNow hold SHIFT while moving to sprint.";
            numberForTutorialWall++;
        }
        if (hasWalkedIntoNewArea == true && numberForTutorialWall == 1)
        {
            CheckIfSprinted();
            if (hasSprinted == true)
            {
                tutorialText.text = "You're getting the hang of it! \nNow go ahead and climb up that ladder.";
                numberForTutorialWall++;
            }
        }
        if (hasClimbedLadder == true && numberForTutorialWall == 2)
        {
            tutorialText.text = "Now that you've climbed the ladder,\njump down on the other side of the house.";
            numberForTutorialWall++;
        }
        if (hasPassedHouse == true && numberForTutorialWall == 3)
        {
            tutorialText.text = "You see that portal like thing?\nThat's an Ember Point. Walk through it.";
            numberForTutorialWall++;
        }
        if (hasWalkedThroughEPOne == true && numberForTutorialWall == 4)
        {
            tutorialText.text = "Welcome\nTo the Fighting Grounds";
            numberForTutorialWall++;
        }
    }

    public void CheckIfSprinted()
    {
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift))
        {
            hasSprinted = true;
        }
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.LeftShift))
        {
            hasSprinted = true;
        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.LeftShift))
        {
            hasSprinted = true;
        }
        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.LeftShift))
        {
            hasSprinted = true;
        }
    }
}
