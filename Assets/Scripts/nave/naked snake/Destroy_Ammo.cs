using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Ammo : MonoBehaviour
{
    public GameObject ammo;
    
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

            Debug.Log("cu");
        }
    }
        
    
}
