using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance;  // Tekil erişim (singleton)

    public Text scoreText;  // UI Text nesnesi
    private int score = 0;

    void Awake()
    {
        // Sahnede tek bir ScoreManager olduğundan emin ol
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        UpdateScoreText();
    }

    public void AddScore(int amount)
    {
        score += amount;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }
}
