using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;

    //Juicing
    public float popSize = 1.3f;   // How big the text grows
    public float popTime = 0.1f;   // How long it stays big
    private Vector3 originalSize;

    void Start()
    {
        UpdateScoreText();
    }

    public void AddScore(int points)
    {
        score += points;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString(); ;

            PopScoreText();
        }
    }

    // Super simple pop effect method
    void PopScoreText()
    {
        scoreText.transform.localScale = originalSize * popSize; // Grow text
        Invoke("ResetScoreTextSize", popTime);             // Reset after a short delay
    }

    // Resets the text to its original size
    void ResetScoreTextSize()
    {
        scoreText.transform.localScale = originalSize;
    }
}
