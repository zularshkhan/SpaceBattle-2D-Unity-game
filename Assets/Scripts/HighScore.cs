using UnityEngine.UI;
using UnityEngine;

public class HighScore : MonoBehaviour
{
    public Text highscore;

    // Start is called before the first frame update
    void Start()
    {
        highscore.text = PlayerPrefs.GetInt("HighScore").ToString();
    }
}
