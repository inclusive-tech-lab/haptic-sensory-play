using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor;

public class DragCar : MonoBehaviour {

    private static bool follow = true;

	// Use this for initialization
	void Start () {
        CreateText();
        Vector3 start = new Vector3(0, 0, 0);
        transform.position = start;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonUp(0))
        {
            follow = false;
        }

        if (follow)
        {
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            pos.z = 0.0f;
            transform.position = pos;
            //rigidbody2D.MovePosition(pos);
        }
    }

    void OnMouseDown()
    {
        follow = true;

        //Touch touch = Input.GetTouch(0);

    }

    void CreateText()
    {
        //Path of the file
        string path = Application.persistentDataPath + "/Log.txt";

        //Create file if it doesn't exist
        if(!File.Exists(path))
        {
            File.WriteAllText(path, "Login log \n\n");
        }

        //Content of the file
        string content = "Login date: " + System.DateTime.Now + "\n";

        //Add some text to it
        File.AppendAllText(path, content);
    }
}
