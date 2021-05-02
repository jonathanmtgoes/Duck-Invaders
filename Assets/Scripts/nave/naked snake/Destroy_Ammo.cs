using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Destroy_Ammo : MonoBehaviour
{
    public GameObject ammo;
    GameObject[] ducks;



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
        if (collision.gameObject.CompareTag("duck"))
        {
            Destroy(collision.gameObject);
            Destroy(ammo);
        }
    }

    private void OnDestroy()
    {
        ducks = GameObject.FindGameObjectsWithTag("duck");

        if (ducks.Length > 0)
        {
            float minX = ducks.Min(duck => duck.transform.position.x);
            float maxX = ducks.Max(duck => duck.transform.position.x);

            GameObject patoEsquerda = GameObject.Find("PatoEsquerda");
            patoEsquerda.transform.SetPositionAndRotation(new Vector3(minX, 0, 0), Quaternion.identity);

            if (minX != maxX)
            {
                GameObject patoDireita = GameObject.Find("PatoDireita");
                patoDireita.transform.SetPositionAndRotation(new Vector3(maxX, 0, 0), Quaternion.identity);
            }

            else 
            {
                GameObject patoDireita = GameObject.Find("PatoDireita");
                Destroy(patoDireita);
            }


        }
    }


}
