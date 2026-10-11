using UnityEngine;
using TMPro;

public class EndScreen : MonoBehaviour
{
    [SerializeField] private TMP_Text finalScoreText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // No ScoreManager object exists in this scene, 
        // but we can still read the static FinalScore through the class name
        finalScoreText.text = "Final Score: " + ScoreManager.FinalScore;
    }
}
