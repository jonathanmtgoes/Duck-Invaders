using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Ammo_Enemy : MonoBehaviour
{
    public float ammo_force_enemy = 7f;
    public float ammo_lifespan_enemy = 3f;
    public GameObject ammo;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * ammo_force_enemy);

        ammo_lifespan_enemy -= Time.deltaTime;
        if (ammo_lifespan_enemy <= 0)
            Destroy(ammo);
    }
}
