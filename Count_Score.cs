using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Count_Score : MonoBehaviour
{
    // Start is called before the first frame update
    public Text Scoreboard;
    public GameObject ball;
    private int Bat_1_Score = 0;
    private int Bat_2_Score = 0;
    public static bool canAddScore = true;
    void Start()
    {
        ball = GameObject.Find("ball");
    }

    // Update is called once per frame
    void Update()
    {
        if(ball.transform.position.x  >= 10f &&canAddScore ){
           canAddScore = false;
           Bat_1_Score  = Bat_1_Score +1;
        }
        if(ball.transform.position.x  <= -10f &&canAddScore ){
             canAddScore = false;
              Bat_2_Score = Bat_2_Score +1;
        }
        if(Bat_1_Score >= 3){
            SceneManager.LoadScene(2);
        }
        if(Bat_2_Score >= 3){
            SceneManager.LoadScene(3);
        }
        Scoreboard.text = Bat_1_Score.ToString() + " - " + Bat_2_Score.ToString(); ;
        // print( Bat_1_Score + "," + Bat_2_Score );
    }
}
