using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float move;
    public float speed = 5f;
    public float jump = 10f;
    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        //move
        if(Input.GetKey(KeyCode.D))
        {
            move = 1;
        } else if(Input.GetKey(KeyCode.A))
        {
            move = -1;
        } else
        {
            move = 0;
        }
        transform.Translate(Vector3.right * speed * move * Time.deltaTime);
        
        //jump
        if(Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space))
        {
            transform.Translate(Vector2.up * jump * Time.deltaTime);
        }
    }
}
