using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetterTracingGM : MonoBehaviour
{

    public Transform dot;
    public KeyCode mouseLeft;
    public static string toolType;
    public static Color currentColor = new Color(21, 80, 255); //default is blue
    public static int currentOrder;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        Vector2 mousePosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
        Vector2 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);

        if (Input.GetKey(mouseLeft)) Instantiate(dot, objPosition, dot.rotation);
    }
}
