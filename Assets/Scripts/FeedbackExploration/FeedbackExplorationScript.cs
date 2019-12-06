using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedbackExplorationScript : MonoBehaviour
{
    private GameObject track1Inside;
    private GameObject track1Outside;

    private GameObject track2Inside;
    private GameObject track2Outside;

    private GameObject track3Inside;
    private GameObject track3Outside;

    private static GameObject haptic;

    void Start()
    {
        //find on scene
        track1Inside = GameObject.Find("TrackOneInsideFeedback");
        track1Outside = GameObject.Find("TrackOneOutsideFeedback");

        track2Inside = GameObject.Find("TrackTwoInsideFeedback");
        track2Outside = GameObject.Find("TrackTwoOutsideFeedback");

        track3Inside = GameObject.Find("TrackThreeInsideFeedback");
        track3Outside = GameObject.Find("TrackThreeOutsideFeedback");

        //hide
        deactivateAll();

        
        
    }

    public void activateTrack1()
    {
        //reset
        deactivateAll();

        if (FeedbackExplorationToggle.feedback == "inside")
        {
            track1Inside.SetActive(true);
            activateHaptic(track1Inside);
        }
        else
        {
            track1Outside.SetActive(true);
            activateHaptic(track1Outside);
        }
        Debug.Log("Activated track 1.");
    }

    public void activateTrack2()
    {
        //reset
        deactivateAll();

        if (FeedbackExplorationToggle.feedback == "inside")
        {
            track2Inside.SetActive(true);
            activateHaptic(track2Inside);
        }
        else
        {
            track2Outside.SetActive(true);
            activateHaptic(track2Outside);
        }
        Debug.Log("Activated track 2.");
    }

    public void activateTrack3()
    {
        //reset
        deactivateAll();

        if (FeedbackExplorationToggle.feedback == "inside")
        {
            track3Inside.SetActive(true);
            activateHaptic(track3Inside);
        }
        else
        {
            track3Outside.SetActive(true);
            activateHaptic(track3Outside);
        }
        Debug.Log("Activated track 3.");
    }

    private void deactivateAll()
    {
        deactivateHaptic();

        track1Inside.SetActive(false);      
        track1Outside.SetActive(false);

        track2Inside.SetActive(false);
        track2Outside.SetActive(false);

        track3Inside.SetActive(false);
        track3Outside.SetActive(false);
    }

    void deactivateHaptic()
    {
        if(haptic != null) haptic.SetActive(false);

        Debug.Log("Haptics deactivated.");
    }

    void activateHaptic(GameObject go)
    {
        //might want to change this code later, not a good idea to call the child by index
        haptic = go.transform.GetChild(0).gameObject;

        haptic.SetActive(true);

        Debug.Log("Haptics activated: " + haptic.name);
    }

}