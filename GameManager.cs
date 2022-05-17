using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject Player;
    public GameObject gameoverText;
    public Text scoreText;
    public Text recordText;

    public int gotScore = 0;
    private int bestScore = 0;
    private bool isGameover;

    // Start is called before the first frame update
    void Start()
    {
        isGameover = false;
    }
    
    // Update is called once per frame
    void Update()
    { 
        scoreText.text = "Score: " + gotScore;
        if (!isGameover)
        {
            float Y = Player.transform.position.y;

            if(Y <= -10)
            {
                Player.SetActive(false);
                EndGame();
            }
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("Rolling");
            }
        }
    }
    
    public void EndGame()
    {
        isGameover = true;
        gameoverText.SetActive(true);

        bestScore = PlayerPrefs.GetInt("BestScore");

        if (gotScore > bestScore)
        {
            bestScore = gotScore;
            PlayerPrefs.SetInt("BestScore", bestScore);
        }
        recordText.text = "Best Score: " + bestScore;

    }

}
