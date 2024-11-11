using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Dependencies.NCalc;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LeftLose : MonoBehaviour
{
    public int PlayerrTwoScore;
    public Text RightText;
    public GameObject RightScore;
    public spawner logic;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<spawner>();
    }
    public void addScore()
    {
        PlayerrTwoScore = PlayerrTwoScore + 1;
        RightText.text = PlayerrTwoScore.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        addScore();
        logic.SpawnBall();
    }

}
