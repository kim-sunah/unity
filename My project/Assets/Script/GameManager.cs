using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject rain;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("makeRain", 0, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void makeRain()
    {
        Instantiate(rain);
    }

}
