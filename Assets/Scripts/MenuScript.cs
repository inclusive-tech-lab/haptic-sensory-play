using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour {

    public static char chosenLetter;

    public void LetterExploration()
    {
        SceneManager.LoadScene("letterexploration", LoadSceneMode.Single);
    }

    public void FeelLetter()
    {
        string l = EventSystem.current.currentSelectedGameObject.GetComponentInChildren<Image>().sprite.ToString();
        chosenLetter = l[0];
        Debug.Log(chosenLetter);

        SceneManager.LoadScene("feelletter", LoadSceneMode.Single);
    }

    public void FeedbackExploration()
    {
        SceneManager.LoadScene("feedbackexploration", LoadSceneMode.Single);
    }

    public void Sandbox()
    {
        SceneManager.LoadScene("sandbox", LoadSceneMode.Single);
    }

    public void Drawing()
    {
        SceneManager.LoadScene("drawing", LoadSceneMode.Single);
    }

    public void Back()
    {
        string sceneName = SceneManager.GetActiveScene().name;
        Debug.Log(sceneName);

        if (sceneName.Equals("feelletter")) SceneManager.LoadScene("letterexploration", LoadSceneMode.Single);
        else SceneManager.LoadScene("main", LoadSceneMode.Single);
    }
}
