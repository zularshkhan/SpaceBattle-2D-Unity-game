using UnityEngine.UI;
using UnityEngine;

public class Score : MonoBehaviour
{
    public Text score;
    [HideInInspector]
    public int count;

    // Update is called once per frame
    void Update()
    {
        sc();
        highscore();
    }

    void highscore()
    {
        if (count > PlayerPrefs.GetInt("HighScore"))
        {
            PlayerPrefs.SetInt("HighScore", count);
        }
        

    }

    void sc()
    {
        score.text = count.ToString();
    }


}
