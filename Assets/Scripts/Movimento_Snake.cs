using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento_Snake : MonoBehaviour
{
    
    public float mov = 10f;
    
    
 
    void Start()
    {
        
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            transform.Translate(new Vector2(0, mov * Time.deltaTime));
        
        if(Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(new Vector2(-mov * Time.deltaTime, 0));

        if (Input.GetKey(KeyCode.DownArrow))
            transform.Translate(new Vector2(0, -mov * Time.deltaTime));

        if (Input.GetKey(KeyCode.RightArrow))
            transform.Translate(new Vector2(mov * Time.deltaTime, 0));

    }
}
