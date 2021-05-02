using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create_Ammo_Enemy : MonoBehaviour
{
    public GameObject ammo_enemy;
    public GameObject barrel_enemy;

    // Start is called before the first frame update
    void Start()
    {
        Instantiate(ammo_enemy, new Vector2(barrel_enemy.transform.position.x, barrel_enemy.transform.position.y), barrel_enemy.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
