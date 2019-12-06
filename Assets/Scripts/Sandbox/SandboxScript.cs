using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SandboxScript : MonoBehaviour {

    private static GameObject sand;
    private static GameObject water;
    private static GameObject slime;
    private static GameObject zen;
    private static GameObject camera;

    private Button pressedButton;
    private ColorBlock selected;
    private ColorBlock unselected;

    private Button waterButton;
    private Button slimeButton;
    private Button sandButton;

    void Start()
    {
        //find on scene
        sand = GameObject.Find("Sand");
        water = GameObject.Find("Water");
        slime = GameObject.Find("Slime");

        //hide
        sand.SetActive(false);
        water.SetActive(false);
        slime.SetActive(false);

        waterButton = GameObject.Find("WaterActivator").GetComponent<Button>();
        slimeButton = GameObject.Find("SlimeActivator").GetComponent<Button>();
        sandButton = GameObject.Find("SandActivator").GetComponent<Button>();

        //defineColorSet();

    }

    private void defineColorSet()
    {
        Color grey = new Color(1f, 1f, 1f, 1f);
        Color darkgrey = new Color(0.7843137f, 0.7843137f, 0.7843137f, 1f);

        selected.highlightedColor = darkgrey;
        selected.normalColor = darkgrey;
        selected.pressedColor = darkgrey;

        unselected.highlightedColor = darkgrey;
        unselected.normalColor = grey;
        unselected.pressedColor = darkgrey;
    }

    public void changeSelection(Button b)
    {
        if (pressedButton != null)
        {
            Debug.Log("Previous pressed btn is " + pressedButton.name);
            Debug.Log("Del prev btn");
            pressedButton.colors = unselected;
            Debug.Log(pressedButton.name + " button color is now " + pressedButton.colors.normalColor.ToString());
            pressedButton = b;
            Debug.Log("Pressed btn is " + pressedButton.name);
            Debug.Log(pressedButton.name + " button color is now " + pressedButton.colors.normalColor.ToString());
            pressedButton.colors = selected;
        }
        else
        {
            Debug.Log("New btn");
            pressedButton = b;
            Debug.Log("Pressed btn is " + pressedButton.name);
            Debug.Log(pressedButton.name + " button color is now " + pressedButton.colors.normalColor.ToString());
            pressedButton.colors = selected;
        }
    }

    public void activateSand()
    {
        if (water.activeSelf) water.SetActive(false);
        
        if (slime.activeSelf) slime.SetActive(false);

        sand.SetActive(true);

        //changeSelection(sandButton);

        Debug.Log("Activated sand.");
    }

    public void activateWater()
    {
        if (sand.activeSelf) sand.SetActive(false);
        if (slime.activeSelf) slime.SetActive(false);

        water.SetActive(true);

        //changeSelection(waterButton);

        Debug.Log("Activated water.");
    }

    public void activateSlime()
    {
        if (sand.activeSelf) sand.SetActive(false);
        if (water.activeSelf) water.SetActive(false);

        slime.SetActive(true);

        //changeSelection(slimeButton);

        Debug.Log("Activated slime.");
    }
}
