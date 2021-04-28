using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_Retorno_Pato : MonoBehaviour
{
    

    
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


            bool flipBool = false;

            if (collision.gameObject.name == "PatoDireita")
            {
                flipBool = false;
            }

            if (collision.gameObject.name == "PatoEsquerda")
            {
                flipBool = true;
            }

            foreach (GameObject duck in ducks)
            {               

                duck.GetComponent<SpriteRenderer>().flipX = !flipBool;

                duck.GetComponent<Mov_Enemy>().veloc *= -1;
            }

            foreach (GameObject duckTrigger in ducksTriggers)
            {
                duckTrigger.GetComponent<Mov_Enemy>().veloc *= -1;
                Debug.Log(duckTrigger.GetComponent<Mov_Enemy>().veloc);
            }
        } 
    }
}
