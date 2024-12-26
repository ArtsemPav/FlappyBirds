using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText1;
    [SerializeField] private TextMeshProUGUI scoreText2;
    public static ScoreManager Instance { get; set; }
    public int score;

    public void Start()
    {
        Instance = this;
        SetScore(0);
    }

    public void SetScore (int score)
    {
        this.score += score;
        scoreText1.text = "Score: " + this.score.ToString();
        scoreText2.text = this.score.ToString();
    }
}
