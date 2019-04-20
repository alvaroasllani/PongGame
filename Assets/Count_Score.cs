using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Count_Score : MonoBehaviour
{
    public Text Scoreboard;
    public GameObject ball;

    public static bool canAddScore = true;

    private int Mando1_puntacion = 0;
    private int Mando2_puntacion = 0;
    // Start is called before the first frame update
    void Start()
    {
        ball = GameObject.Find("Bola");
    }

    // Update is called once per frame
    void Update()
    {
        if(ball.transform.position.x >= 19.5f && canAddScore){
            canAddScore = false;
            Mando1_puntacion ++;
            //ball.transform.position = Vector3.zero;
        }
        if(ball.transform.position.x <= -19.5f && canAddScore){
            canAddScore = false;
            Mando2_puntacion ++;
             // ball.transform.position = Vector3.zero;
        }
        
        if(Mando1_puntacion >= 7){
            SceneManager.LoadScene(2);
        }
        if(Mando2_puntacion >= 7){
            SceneManager.LoadScene(3);
        }
        
        Scoreboard.text = Mando1_puntacion.ToString () + " - " + Mando2_puntacion.ToString();
       
    }
}
