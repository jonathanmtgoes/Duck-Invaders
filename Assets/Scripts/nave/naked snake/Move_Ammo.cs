using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Ammo : MonoBehaviour
{
    public float ammo_force = 7f;
    public float ammo_lifespan = 1.5f;
    public GameObject ammo;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * ammo_force);

        ammo_lifespan -= Time.deltaTime;
        if (ammo_lifespan <= 0)
            Destroy(ammo);

    }
}
