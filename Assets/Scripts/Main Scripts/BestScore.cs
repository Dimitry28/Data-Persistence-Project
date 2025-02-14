using TMPro;
using UnityEditor.Overlays;
using UnityEngine;


public class BestScore : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI bestScoreText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if(DataManager.Instance.recordOwner == null)
        {
            bestScoreText.text = "Best Score: : 0";
        }
        else
        {
            StartingHighScore();
        }
    }

    void StartingHighScore()
    {
        DataManager.Instance.LoadData();
        bestScoreText.text = " Best Score: " + DataManager.Instance.recordOwner + " : " + DataManager.Instance.recordScore;
    }


    public void StablishNewRecord(int points)
    {
        if (DataManager.Instance.recordScore < points)
        {
            DataManager.Instance.highScore = points;
            DataManager.Instance.SaveData();
        }

    }
}
