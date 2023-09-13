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
    public Animator anim;
    public Text maxScoreTxt;

    public void retry()
    {
        SceneManager.LoadScene("MainSecene");
    }

    public void gameOver()
    {
        isRunning = false;
        Invoke("timeStop", 0.5f);
        anim.SetBool("isDie", true);
         
        endPanel.SetActive(true);
        thisScoreTxt.text = alive.ToString("N2");
        if(PlayerPrefs.HasKey("bastscore") == false)
        {
            PlayerPrefs.SetFloat("bastscore", alive);
        }
        else
        {
            if(alive > PlayerPrefs.GetFloat("bastscore"))
            {
                PlayerPrefs.SetFloat("bastscore", alive);
            }
        }
        float maxScore = PlayerPrefs.GetFloat("bastscore");
        maxScoreTxt.text = maxScore.ToString("N2");

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
    void timeStop()
    {
        Time.timeScale = 0f;
    }
}


//PlayerPrefs.SetInt('age', 10);
//PlayerPrefs.SetString('name', 'donghyn lee');
//PlayerPrefs.GetString('name');