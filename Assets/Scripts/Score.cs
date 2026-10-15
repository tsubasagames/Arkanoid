using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    private int score = 0;
    public Text ScoreTextParamedic;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ScoreTextMcDouble();
    }
    void ScoreTextMcDouble()
    {
        ScoreTextParamedic.text = "Score: " + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
  public void count(int sumpoint)
    {
        score += sumpoint;
        ScoreTextMcDouble();
           
    }
}
