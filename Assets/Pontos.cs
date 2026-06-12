using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pontos : MonoBehaviour
{
    float points=0;

    public Text scoreText;

    void Start()
    {
        scoreText.text="0";
    }

    public void AddPoints()
    {
       points++;
       scoreText.text=points.ToString(); 
    }
}
