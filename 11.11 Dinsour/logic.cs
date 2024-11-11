using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class logic : MonoBehaviour
{
    public GameObject gameoverScreen;
    public GameObject HighestScore;
    int score;
    public Text Scoretext;
    public Text HighestScoreText;
    float scoretimer = 0;
    public bool gameover = false;


    // Start is called before the first frame update
    void Start()
    {
        HighestScoreText.text = PlayerPrefs.GetInt("HighScore").ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (scoretimer < 2)
        {
            scoretimer = scoretimer + Time.deltaTime;
        }
        else if (gameover == false)
        {
            SocreUp();
            scoretimer = 0;
        }

    }
      public void restartgame()
    { 
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    public void gameOver()
    {
        gameover = true;
        HighestScoreText.text = PlayerPrefs.GetInt("HighScore").ToString();
        CheckHighScore();
        gameoverScreen.SetActive(true);       
    }
    public void SocreUp()
    {
        score += 100;
        Scoretext.text = score.ToString(); ;
    }
    public void CheckHighScore() 
    {
        if (score > PlayerPrefs.GetInt("HighScore", 0))

        {
            PlayerPrefs.SetInt("HighScore", score);
        
        }
    }

  
}
