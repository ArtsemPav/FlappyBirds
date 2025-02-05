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
    public GameObject Sound;
    public Spawner SpawnPrefab;
    public MoveObject moveObject;

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
        if ((this.score % 6 == 0) && (this.score != 0) && (SpawnPrefab.timeToSpawn > 0.2f))
        {
            IncreaseDifficoult();
        }
    }

    public void PlaySound()
    {
        AudioSource sound = Sound.GetComponent<AudioSource>();
        sound.Play();
    }

    public void IncreaseDifficoult()
    {
        moveObject.speed = moveObject.speed + 0.4f;
        SpawnPrefab.timeToSpawn = SpawnPrefab.timeToSpawn - 0.2f;
    }
}
