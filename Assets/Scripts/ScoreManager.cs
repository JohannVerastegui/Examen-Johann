using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;

    private int score = 0;

    [SerializeField] textMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }

    void start()
    {
        UpdateScoreUI();
    }

    public void IncrementScore(int value)
    {
        score += value;
        UpdateScoreUI();
    }

    // Update is called once per frame
    void UpdateScoreUI()
    {
        scoreText.text = "Puntaje:" + score.ToString();
    }
}
