using TMPro;
using UnityEngine;

public class ScoreDislplay : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI display;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        display.text = Score.score.ToString();
    }
}
