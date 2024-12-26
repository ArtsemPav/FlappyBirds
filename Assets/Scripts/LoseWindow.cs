using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LoseWindow : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI BestScoreText;
    public void PlayerLose()
    {
        int score = ScoreManager.Instance.score;
        ScoreText.text = score.ToString();
        int bestScore = PlayerPrefs.GetInt("BestScore");
        if (bestScore < score)
        {
            bestScore = score;
        }
        BestScoreText.text = bestScore.ToString();
        PlayerPrefs.SetInt("BestScore", bestScore);
    }
}
