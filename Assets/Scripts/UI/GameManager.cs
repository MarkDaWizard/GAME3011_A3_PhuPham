using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Slider scoreBar;
    public TextMeshProUGUI scoreText, maxScoreText, difficultyText;
    public TextMeshProUGUI timerText;
    public UIManager gameManager;
    public GameObject winUI, loseUI;
    public int score = 0;
    public int maxScore = 10000;
    public int maxTime = 90;
    public bool isWon = false;
    public bool isLose = false;


    float timeMin = 0, timeSec = 0;
    

    // Start is called before the first frame update
    void Start()
    {
       
        switch(gameManager.gameDifficulty)
        {
            case 0:
                //easy
                maxScore = 50000;
                maxTime = 480;
                difficultyText.text = "Difficulty: Easy";
                break;
            case 1:
                //medium
                maxScore = 75000;
                maxTime = 300;
                difficultyText.text = "Difficulty: Medium";
                break;
            case 2:
                //bla
                maxScore = 80000;
                maxTime = 240;
                difficultyText.text = "Difficulty: Hard";
                break;
            default:
                //easy default
                maxScore = 10000;
                maxTime = 300;
                difficultyText.text = "Difficulty: Easy";
                break;
        }
        maxScoreText.text = maxScore.ToString();
        scoreBar.maxValue = maxScore;
        timeMin = maxTime / 60;
        timeSec = maxTime % 60;
    }

    // Update is called once per frame
    void Update()
    {
        if(isWon)
        {
            print("u win");
            winUI.SetActive(true);
            return;
        }
        
        if(isLose)
        {
            print("u lose");
            loseUI.SetActive(true);
            return;
        }
        UpdateTimer();

        scoreBar.value = score;
        if(timeSec <= 9)
            timerText.text = timeMin.ToString("F0") + ":0" + timeSec.ToString("F0");
        else
            timerText.text = timeMin.ToString("F0") + ":" + timeSec.ToString("F0");

    }

    public void AddScore()
    {
        score += 100;
        scoreText.text = score.ToString();
        if (score >= maxScore)
            isWon = true;
    }

    public void UpdateTimer()
    {
        if (!(timeMin <= 0 && timeSec <= 0))
        {
            if (timeSec >= 0)
            {
                timeSec -= Time.deltaTime;
            }
            else
            {
                timeMin--;
                timeSec = 59;
            }
        }
        else
            isLose = true;
    }
}
