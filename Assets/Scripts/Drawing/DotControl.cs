using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DotControl : MonoBehaviour {

    private bool follow = true;

	// Use this for initialization
	void Start () {
        GetComponent<SpriteRenderer>().color = PaintGM.currentColor;
	}
	
	// Update is called once per frame
	void Update () {

    }

    void OnMouseDrag()
    {
        if (PaintGM.toolType == "eraser")
        {
            Destroy(gameObject);
        }
    }
}
