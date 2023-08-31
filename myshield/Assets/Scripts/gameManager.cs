using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameManager : MonoBehaviour
{
    public GameObject square;
    public Text timeTxt;
    float alive = 0f;
    public static gameManager I;
    public GameObject endPanel;
    public Text thisScoreTxt;
    bool isRunning = true;

    public void retry()
    {
        SceneManager.LoadScene("MainSecene");
    }

    public void gameOver()
    {
        isRunning = false;
        Time.timeScale = 0.0f;
        endPanel.SetActive(true);
        thisScoreTxt.text = alive.ToString("N2");
    }

    private void Awake()
    {
        I = this;
    }

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
        InvokeRepeating("makeSquare", 0.0f, 0.5f);


    }

    // Update is called once per frame
    void Update()
    {
        if (isRunning)
        {
            alive += Time.deltaTime;
            timeTxt.text = alive.ToString("N2");
        }
    }

    void makeSquare()
    {
        Instantiate(square);
    }
}
