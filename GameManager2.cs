using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager2 : MonoBehaviour
{
    public GameObject gameoverText;
    public Text scoreText;
    public Text recordText;

    private int gotScore;
    private bool isItem;

    // Start is called before the first frame update
    void Start()
    {
        gotScore = 0;
        isItem = false;
    }
    /*
    // Update is called once per frame
    void Update()
    {
        if (isItem)
        {
            
            scoreText.text = "Score: " + gotScore;
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("New Scene");
            }
        }
    }

    public void EndGame()
    {
        isGameover = true;
        gameoverText.SetActive(true);

        float bestTime = PlayerPrefs.GetFloat("BestTime");

        if (surviveTime > bestTime)
        {
            bestTime = surviveTime;
            PlayerPrefs.SetFloat("BestTime", bestTime);
        }
        recordText.text = "Best Time: " + (int)bestTime;
    }
    */
}
