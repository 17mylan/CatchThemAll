using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int Score = 0;
    public TextMeshProUGUI scoreText;
    private void Start()
    {
        UpdateScore();
    }
    public void AddPoints(int _points)
    {
        Score = Score + _points;
        UpdateScore();
    }
    public void UpdateScore()
    {
        scoreText.text = "Score: " + Score;
    }
}
