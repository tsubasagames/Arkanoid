using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public int score = 0;
    public Text ScoreTextParamedic;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ScoreTextMcDouble();
    }
    void ScoreTextMcDouble()
    {
        Debug.Log("3 The Script Is Working" + score);
        ScoreTextParamedic.text = "Score: " + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {

    }
  public void count(int sumpoint)
    {
        Debug.Log("2 The Script Is Working" + sumpoint);
        score += sumpoint;
        ScoreTextMcDouble();
           
    }
}
