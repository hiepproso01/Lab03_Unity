using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bat_2_Controller : MonoBehaviour
{
    // Start is called before the first frame update
      private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();   
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow)){
            rb.velocity = new Vector2(0f,5f);
        }else if(Input.GetKey(KeyCode.DownArrow)){
            rb.velocity = new Vector2(0f,-5f);
        }else{
             rb.velocity = new Vector2(0f,0f);
        }
    }
}
