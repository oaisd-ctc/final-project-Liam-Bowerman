using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterNewArea : MonoBehaviour
{
    public GameObject gameObject;
    public TutorialScrpit tutorialScript;
    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.name == "Wall to second area")
        {
            tutorialScript.hasWalkedIntoNewArea = true;
        }
        if (gameObject.name == "Climb the ladder")
        {
            tutorialScript.hasClimbedLadder = true;
        }
        if (gameObject.name == "Fall wall")
        {
            tutorialScript.hasPassedHouse = true;
        }
        if (gameObject.name == "Ember point one")
        {
            tutorialScript.hasWalkedThroughEPOne = true;
        }
    }
}
