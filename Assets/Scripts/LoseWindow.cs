using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LoseWindow : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    public TextMeshProUGUI BestScoreText;
    public Medal[] medals;
    public Image MedalDisplay;
    public void PlayerLose()
    {
        int score = ScoreManager.Instance.score;
        ScoreText.text = score.ToString();
        int bestScore = PlayerPrefs.GetInt("BestScore");
        if (bestScore < score)
        {
            bestScore = score;
        }
        for (int i=0; i < medals.Length; i++)
        {
            if (medals[i].scoreNeed <= score)
            {
                MedalDisplay.gameObject.SetActive(true);
                MedalDisplay.sprite = medals[i].MedalSprite;
            }
        }


        BestScoreText.text = bestScore.ToString();
        PlayerPrefs.SetInt("BestScore", bestScore);
    }
}
