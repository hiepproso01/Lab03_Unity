using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Ball_Controller : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Bat1;
    public GameObject Bat2;
    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Bat1 = GameObject.Find("bat1");
        Bat2 = GameObject.Find("bat2");
        // Count_Score.canAddScore = true;
        StartCoroutine(Pause());
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Mathf.Abs(this.transform.position.x)  >= 11f){

            Count_Score.canAddScore = true;
            this.transform.position = new Vector3 (0f, 0f,0f);
            StartCoroutine(Pause());
        }
        //  if(this.transform.position.x  <= -10f){
        //       this.transform.position = new Vector3 (0f, 0f,0f);
        //       StartCoroutine(Pause());
        // }
        
      
    }
    IEnumerator Pause(){
        int directionX =Random.Range(-1,2);
        int directionY =Random.Range(-1,2);
        if(directionX == 0){
            directionX = 1 ;
        }

        rb.velocity = new Vector2 (0f, 0f);
        yield return new WaitForSeconds(2);
        rb.velocity = new Vector2 (12f * directionX, 10f * directionY);
    }
      void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.name =="bat1"){
            if(Bat1.GetComponent<Rigidbody2D>().velocity.y > 0.5f){
                 rb.velocity = new Vector2 (10f  , 10f );

            } else if ( Bat1.GetComponent<Rigidbody2D>().velocity.y < -0.5f){
                  rb.velocity = new Vector2 (10f ,-10f );
            }else{
                 rb.velocity = new Vector2 (14f  , 0f );
            }
        }
         if(other.gameObject.name =="bat2"){
           if(Bat2.GetComponent<Rigidbody2D>().velocity.y > 0.5f){
                 rb.velocity = new Vector2 (-10f  , 10f );

            } else if ( Bat2.GetComponent<Rigidbody2D>().velocity.y < -0.5f){
                  rb.velocity = new Vector2 (-10f ,-10f );
            }else{
                 rb.velocity = new Vector2 (-14f  , 0f );
            }
        }
    }
}
