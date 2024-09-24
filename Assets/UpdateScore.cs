using UnityEngine;
using TMPro;

public class UpdateScore : MonoBehaviour
{
    public static UpdateScore Instance { get; private set; }

    private TMP_Text scoreText;
    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = gameObject.GetComponent<TextMeshPro>();
        UpdateScoreText();
        GameEvents.OnPipeCrossing += IncreaseScore;
    }

    private void UpdateScoreText()
    {
        scoreText.text = "Score: " + score;
    }

    public void IncreaseScore(int additionalScore)
    {
        score +=additionalScore;
        UpdateScoreText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
