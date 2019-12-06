using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PopulateGrid : MonoBehaviour
{
    public GameObject prefab; // This is our prefab object that will be exposed in the inspector.

    public int numberToCreate; // number of objects to create. Exposed in inspector.

    private string[] alphabet = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };

    void Start()
    {
        Populate();
    }

    void Update()
    {

    }

    void Populate()
    {
        GameObject newObj; // Create GameObject instance

        for (int i = 0; i < numberToCreate; i++)
        {
            // Create new instances of our prefab until we've created as many as we specified
            newObj = (GameObject)Instantiate(prefab, transform);

            // Randomize the color of our image
            //newObj.GetComponentInChildren<Text>().text = this.alphabet[i];

            string btnPath = "Letters/Buttons/" + this.alphabet[i] + "btn";
            Sprite btn = Resources.Load<Sprite>(btnPath);
            newObj.GetComponentInChildren<Image>().sprite = btn;
        }

    }
}