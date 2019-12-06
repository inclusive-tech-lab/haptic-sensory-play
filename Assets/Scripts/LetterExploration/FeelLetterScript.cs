using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeelLetterScript : MonoBehaviour {

    //public GameObject prefab; // This is our prefab object that will be exposed in the inspector.
    //public GameObject newObj;

    public Transform stroke;
    public KeyCode mouseLeft;
    public static Color currentColor = new Color(21, 80, 255); //default is blue

    private List<Transform> strokes = new List<Transform>(); // Will probably need to do something with this in the future to create the reset/undo function.

    // Use this for initialization
    void Start () {
        
        //Also a part of the implementation with the ray. Commenting for now, might go back and keep trying at a later time.
        /*//GameObject newObj; // Create GameObject instance
        // Create new instances of our prefab
        newObj = (GameObject)Instantiate(prefab, null);
        Debug.Log("Created new swipe object.");

        // Add the new swipe to list. Will be usure for new features in the future.
        //this.swipes.Add(newObj);*/
    }
	
	// Update is called once per frame
	void Update () {

        Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
        
        if ((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) || Input.GetMouseButton(0))
        {
            Debug.Log("Instantiating...");
            Transform s = GameObject.Instantiate(stroke, objPosition, stroke.rotation);
            this.strokes.Add(s);
        }

        //This is the implementation with the ray. I prefer this approach, but having a hard time getting it to where I want it to be.
        /*Plane objPlane = new Plane(Camera.main.transform.forward * -1, newObj.transform.position);

        if (((Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) || Input.GetMouseButton(0)))
        {
            Debug.Log("Touch count: " + Input.touchCount);
            Debug.Log("Drawing swipe.");
            //GameObject newObj; // Create GameObject instance
            // Create new instances of our prefab
            //newObj = (GameObject)Instantiate(prefab, transform);

            Ray mRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            float rayDistance;
            if (objPlane.Raycast(mRay, out rayDistance))
                newObj.transform.position = mRay.GetPoint(rayDistance);
        }*/
    }

    public void ResetTrace()
    {
        for(int i=0; i < this.strokes.Count; i++)
        {
            Destroy(this.strokes[i].gameObject);
        }
        this.strokes.Clear();
    }
}
