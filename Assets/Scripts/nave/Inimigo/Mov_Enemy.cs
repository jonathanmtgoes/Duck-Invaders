using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mov_Enemy : MonoBehaviour
{
    public float veloc = 2f;

    void Start()
    {
    }

    void Update()
    {
        transform.Translate(new Vector2(Time.deltaTime * veloc, 0));    
    }
}
