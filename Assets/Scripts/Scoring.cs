using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scoring : MonoBehaviour
{
    public static Scoring Instance { get; private set; }

    [SerializeField]
    private TextMeshProUGUI scoreText;

    private int score = 0;

    // Ensure that only one instance of Scoring exists
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        UpdateScoreText();
    }

    // Updates the current score count
    public void AddScore(int points)
    {
        score += points;
        UpdateScoreText();
    }

    // updates the onscreen text to reflect the current score
    private void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = $"Score: {score}";
        }
    }
}
