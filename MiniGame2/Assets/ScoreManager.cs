using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    public int score;
    public int  mulit = 5;
    public Text scoreDisplay;

   
        
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Obstacle"))
        {
            score+=mulit;
           scoreDisplay.text = score.ToString();
            
        }
    }
}
