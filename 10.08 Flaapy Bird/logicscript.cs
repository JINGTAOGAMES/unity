using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class logicscript : MonoBehaviour
{
    public int PlayerScore;
    public Text scoreText;
    public GameObject gameoverScreen;

    [ContextMenu("Increase Score")]
    public void addScore() {
        PlayerScore = PlayerScore + 1;
        scoreText.text = PlayerScore.ToString();
        }
    public void Restartgame()
        {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
         }
    public void gameOver() { 
    gameoverScreen.SetActive(true);
    }
   
}
