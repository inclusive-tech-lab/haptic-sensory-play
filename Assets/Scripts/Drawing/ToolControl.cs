using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToolControl : MonoBehaviour {

    private static GameObject haptic;
    private static bool hapticEnabled;

    private GameObject noise;
    private GameObject bump;
    private GameObject soft;

    private Button lastSelection;

	// Use this for initialization
	void Start () {
        //haptic = null;
        //hapticEnabled = false;

        //find on scene
        noise = GameObject.Find("NoiseBrushButton").transform.GetChild(0).gameObject;
        bump = GameObject.Find("BumpyBrushButton").transform.GetChild(0).gameObject;
        soft = GameObject.Find("SoftBrushButton").transform.GetChild(0).gameObject;

        //hide
        deactivateAllHaptics();
    }

    private void deactivateAllHaptics()
    {
        //deactivateHaptic();

        noise.SetActive(false);
        bump.SetActive(false);
        soft.SetActive(false);
    }

    // Update is called once per frame
    void Update () {

    }

    public void activateNoise(Button b)
    {
        //reset
        deactivateAllHaptics();

        activate(b, "noisebrush");
        noise.SetActive(true);
    }

    public void activateBump(Button b)
    {
        //reset
        deactivateAllHaptics();

        activate(b, "bumpybrush");
        bump.SetActive(true);
        Debug.Log("Activated " + bump.name);
    }

    public void activateSoft(Button b)
    {
        //reset
        deactivateAllHaptics();

        activate(b, "softbrush");
        soft.SetActive(true);
    }

    private void activate(Button brush, string type)
    {
        //if (hapticEnabled == true) deactivateHaptic();
        resetSelection();
        this.lastSelection = brush;
        PaintGM.toolType = type;
        Debug.Log(PaintGM.toolType + " selected.");
        brush.GetComponent<Image>().sprite = Resources.Load<Sprite>(PaintGM.toolType + "-sel");
        //activateHaptic(brush);
    }

    private void resetSelection()
    {
        if(PaintGM.toolType != null) lastSelection.GetComponent<Image>().sprite = Resources.Load<Sprite>(PaintGM.toolType);
    }

    void deactivateHaptic()
    {
        hapticEnabled = false;
        haptic.SetActive(false);

        Debug.Log("Haptics deactivated.");
    }

    void activateHaptic(Button b)
    {
        hapticEnabled = true;

        //might want to change this code later, not a good idea to call the child by index
        haptic = b.transform.GetChild(0).gameObject;

        haptic.SetActive(true);

        Debug.Log("Haptics activated: " + haptic.name);
    }

    void OnMouseDown()
    {/*
        //if a different brush has already been selected, reset first
        if (hapticEnabled == true) deactivateHaptic();

        switch(gameObject.name)
        {
            case "Eraser":
                PaintGM.toolType = "eraser";
                Debug.Log("Eraser selected.");
                break;
            case "NoiseBrush":
                PaintGM.toolType = "noisebrush";
                Debug.Log("Noise brush selected.");
                activateHaptic();
                break;
            case "BumpyBrush":
                PaintGM.toolType = "bumpybrush";
                Debug.Log("Bumpy brush selected.");
                activateHaptic();
                break;
            case "SoftBrush":
                PaintGM.toolType = "softbrush";
                Debug.Log("Soft brush selected.");
                activateHaptic();
                break;
            default:
                Debug.Log("Default case " + gameObject.name + " selected.");
                break;
        }*/
    }
}
