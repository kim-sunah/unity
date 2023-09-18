using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{

    public GameObject dog;
    public GameObject food;
    public GameObject nomalCat;
    public static gameManager I;
    public GameObject retryBtn;
    int level = 0;
    int cat = 0;
    public Text levelText;
    public GameObject levelFront;

    // Start is called before the first frame update
    //싱글톤화
    private void Awake()

    {
        I = this;
    }

    void Start()
    {
        InvokeRepeating("makeFood", 0.0f, 0.02f);
        InvokeRepeating("makeCat", 0.0f, 1.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void makeFood()
    {
        float x = dog.transform.position.x;
        float y = dog.transform.position.y + 2.0f;
        Instantiate(food, new Vector3(x, y, 0), Quaternion.identity);
    }
    void makeCat()
    {
        Instantiate(nomalCat);
    }

    public void gameOber()
    {
        retryBtn.SetActive(true);
        Time.timeScale = 0;
    }
    public void addCat()
    {
        cat += 1;
        level = cat / 5;

        levelText.text = level.ToString();
        levelFront.transform.localScale = new Vector3((cat - level * 5) / 5.0f, 1.0f, 1.0f);
    }
}
