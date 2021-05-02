using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;


public class Trigger_Retorno_Pato : MonoBehaviour
{
    public float descVeloc = 1f;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {        

        if(collision.gameObject.CompareTag("duckTrigger"))
        {
            GameObject[] ducks;
            GameObject[] ducksTriggers;

            ducks = GameObject.FindGameObjectsWithTag("duck");
            ducksTriggers = GameObject.FindGameObjectsWithTag("duckTrigger");

            foreach (GameObject duck in ducks)
            {               
                duck.GetComponent<Mov_Enemy>().veloc *= -1;
                duck.GetComponent<SpriteRenderer>().flipX = duck.GetComponent<Mov_Enemy>().veloc < 0;

                if (ducks.Length <= 6)
                {
                    duck.transform.Translate(Vector2.down * descVeloc);
                    duck.GetComponent<Mov_Enemy>().veloc *= 1.25f;
                }
            }

            foreach (GameObject duckTrigger in ducksTriggers)
            {
                // duckTrigger.GetComponent<Mov_Enemy>().veloc *= -1;
                if (ducks.Length > 0)
                    duckTrigger.GetComponent<Mov_Enemy>().veloc = ducks.First().GetComponent<Mov_Enemy>().veloc;
                else
                {
                    Destroy(duckTrigger);
                }
            }
        }
    }
}
