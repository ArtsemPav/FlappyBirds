using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI scoreText;
    public static ScoreManager Instance { get; set; }
    private int score;

    public void Start()
    {
        Instance = this;
        SetScore(0);
    }

    public void SetScore (int score)
    {
        this.score += score;
        scoreText.text = "Score: " + this.score.ToString();
    }
}
