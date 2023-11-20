using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreUI : MonoBehaviour
{

    public TextMeshProUGUI scoreText;
    //public bounce scorescript;
    private int saveScore; 
    
    void Start(){
        saveScore = PlayerPrefs.GetInt("Score", 0);
    }
    void Update(){
        scoreText.text = "Score : " + saveScore;
    }
    
}
