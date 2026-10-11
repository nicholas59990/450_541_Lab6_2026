using UnityEngine;
using TMPro; // TMP Text

public class HUDController : MonoBehaviour
{
    [Header("Score")]
    [SerializeField] private TMP_Text scoreText;

    // Update is called once per frame
    void Update()
    {
        UpdateScore();
    }

    private void UpdateScore() {
        // The Score property from Lab 5: anyone can read it
        scoreText.text = "Score: " + ScoreManager.Instance.Score;
    }
}
