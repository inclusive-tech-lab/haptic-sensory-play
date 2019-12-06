using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FeedbackExplorationToggle : MonoBehaviour {

    public static string feedback = "inside";
    private GameObject track1Inside;
    private GameObject track1Outside;

    private GameObject track2Inside;
    private GameObject track2Outside;

    private GameObject track3Inside;
    private GameObject track3Outside;

    // Use this for initialization
    void Start () {
        track1Inside = GameObject.Find("TrackOneInsideFeedback");
        track1Outside = GameObject.Find("TrackOneOutsideFeedback");
        track2Inside = GameObject.Find("TrackTwoInsideFeedback");
        track2Outside = GameObject.Find("TrackTwoOutsideFeedback");
        track3Inside = GameObject.Find("TrackThreeInsideFeedback");
        track3Outside = GameObject.Find("TrackThreeOutsideFeedback");
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void toggleFeedback(Toggle t)
    {
        if (feedback == "inside")
        {
            if (track1Inside.activeSelf)
            {
                track1Outside.SetActive(true);
                track1Inside.SetActive(false);
            }
            if (track2Inside.activeSelf)
            {
                track2Outside.SetActive(true);
                track2Inside.SetActive(false);
            }
            if (track3Inside.activeSelf)
            {
                track3Outside.SetActive(true);
                track3Inside.SetActive(false);
            }
            feedback = "outside";
            t.GetComponentInChildren<Text>().text = "Texture on Track";
        }
        else if (feedback == "outside")
        {
            if (track1Outside.activeSelf)
            {
                track1Inside.SetActive(true);
                track1Outside.SetActive(false);
            }
            if (track2Outside.activeSelf)
            {
                track2Inside.SetActive(true);
                track2Outside.SetActive(false);
            }
            if (track3Outside.activeSelf)
            {
                track3Inside.SetActive(true);
                track3Outside.SetActive(false);
            }
            feedback = "inside";
            t.GetComponentInChildren<Text>().text = "Texture on Background";
        }
    }
}
