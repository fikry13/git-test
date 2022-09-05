using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Test : MonoBehaviour
{
    public Text testText;

    private int num;

    private float timer;

    // Update is called once per frame
    void Update()
    {
        if(timer >= 2)
        {
            num+=2;
            timer = 0;
            testText.text = num.ToString();
        }
        else
        {
            timer += Time.deltaTime;
        }
    }
}
