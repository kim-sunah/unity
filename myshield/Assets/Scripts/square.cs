using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class w1uq43 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      float x = Random.Range(-3f, 3f);
        float y = Random.Range(3f, 5f);
        transform.position = new Vector3(x, y, 0);

        float size = Random.Range(0.5f, 1.5f);
        transform.localScale = new Vector3(size, size, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}