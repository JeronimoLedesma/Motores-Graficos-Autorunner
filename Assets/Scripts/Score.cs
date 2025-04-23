using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public static int score;
    [SerializeField] TextMeshProUGUI scoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
