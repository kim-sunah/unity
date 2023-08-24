using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public static GameManager I;
    public GameObject rain;
    int totalScore =0;
    public Text scoreText;
    float limit = 1f;
    public Text timeText;
    public GameObject panel;

    void Awake()
    {
        I = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        initGame();
        InvokeRepeating("makeRain", 0, 1f);

    }

    // Update is called once per frame
    void Update()
    {
        limit -= Time.deltaTime;

        if(limit < 0)
        {
            panel.SetActive(true);
            Time.timeScale = 0.0f;
            limit = 0.0f;
        }
        timeText.text = limit.ToString("N2");
    }

    void makeRain()
    {
        Instantiate(rain);
    }

    public void addScore(int score)
    {
        Debug.Log("더해진 totalScore" + totalScore);
        totalScore += score;
        scoreText.text = totalScore.ToString();
    }
    public void retry()
    {
        SceneManager.LoadScene("MainScene");
    }
    void initGame()
    {
        Time.timeScale = 1.0f;
        limit = 1f;
        totalScore = 0;

    }

}
