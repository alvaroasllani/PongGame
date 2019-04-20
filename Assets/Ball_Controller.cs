using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Controller : MonoBehaviour
{
    private Rigidbody2D rb;
    public GameObject mando1;
    public GameObject mando2;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        mando1 = GameObject.Find("Mando_1");
        mando2 = GameObject.Find("Mando_2");
        StartCoroutine (Pause());
    }

    // Update is called once per frame
    void Update()
    {
        if(Mathf.Abs(this.transform.position.x) >= 20f){

            Count_Score.canAddScore = true;

            this.transform.position = new Vector3(0f, 0f, 0f);
            StartCoroutine (Pause());
        }
        
    }   
        IEnumerator Pause(){
        int directionX = Random.Range(-1, 2);
        int directionY = Random.Range(-1, 2);

        if(directionX == 0){
            directionX = 1;
        }
        rb.velocity = new Vector2 (0f, 0f);
        yield return new WaitForSeconds (2);
        rb.velocity = new Vector2 (12f * directionX, 10f * directionY);
    }
    void onCollisionEnter2D(Collision2D hit){
        if(hit.gameObject.name == "Mando_1"){
            if(mando1.GetComponent<Rigidbody2D>().velocity.y > 0.5f){
                rb.velocity = new Vector2(10f, 10f);
            } else if (mando1.GetComponent<Rigidbody2D>().velocity.y > -0.5f){
                rb.velocity = new Vector2(10f, -10f);
            } else{
                rb.velocity = new Vector2(12f, 0f);
            }
        }
        if(hit.gameObject.name == "Mando_2"){
            if(mando2.GetComponent<Rigidbody2D>().velocity.y > 0.5f){
                rb.velocity = new Vector2(-10f, 10f);
            } else if (mando2.GetComponent<Rigidbody2D>().velocity.y > -0.5f){
                rb.velocity = new Vector2(-10f, -10f);
            } else{
                rb.velocity = new Vector2(-12f, 0f);
            }
        }
    }
}
