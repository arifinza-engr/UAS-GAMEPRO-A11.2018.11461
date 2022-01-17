using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoringSystem : MonoBehaviour
{
    public GameObject scoreText;
    public static int theScore;

    void Update()
    {
        scoreText.GetComponent<Text>().text = "SCORE : " + theScore;
        if (theScore >= 300)
        {
            scoreText.GetComponent<Text>().text = "YOU WINNNN !!!";
            Debug.Log("sceneBuildIndex to load: " + 2);
            SceneManager.LoadScene(2);
        }
        else if (theScore < 0)
        {
            scoreText.GetComponent<Text>().text = "YOU LOSEEEE !!!";
            Debug.Log("sceneBuildIndex to load: " + 3);
            SceneManager.LoadScene(3);
        }
        if (Input.GetKey("escape"))
        {
            Debug.Log("sceneBuildIndex to load: " + 0);
            SceneManager.LoadScene(0);
        }
    }
}
