using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RightLose : MonoBehaviour
{

    public int PlayerrOneScore;
    public Text LeftText;
    public GameObject LeftScore;
    public spawner logic;
    // Start is called before the first frame update
void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<spawner>();
    }
    public void addScore2()
    {
        PlayerrOneScore = PlayerrOneScore + 1;
        LeftText.text = PlayerrOneScore.ToString();
    }
    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        addScore2();
        logic.SpawnBall1();
    }
}
