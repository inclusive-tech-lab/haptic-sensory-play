using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorPicker : MonoBehaviour {

    private Button lastSelection;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void pickColor(Button color)
    {
        PaintGM.currentColor = color.GetComponent<Image>().color;
        resetSelection();
        this.lastSelection = color;
        color.GetComponent<Image>().sprite = Resources.Load<Sprite>("white-block-sel");
        Debug.Log(PaintGM.currentColor);
        PaintGM.currentOrder++;
    }

    private void resetSelection()
    {
        if (this.lastSelection != null) this.lastSelection.GetComponent<Image>().sprite = Resources.Load<Sprite>("white-block");
    }
}
