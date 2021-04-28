using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov_nave : MonoBehaviour
{

    public float vel = 5f;
    public float horizontal;

    void Start()
    {

    }

    void Update()
    {
        /*
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Translate(new Vector2(-mov * Time.deltaTime, 0));

        if (Input.GetKey(KeyCode.RightArrow))
            transform.Translate(new Vector2(mov * Time.deltaTime, 0));
        */

        horizontal = Input.GetAxis("Horizontal");
        transform.Translate(new Vector2(horizontal * Time.deltaTime * vel, 0));
    }
}
