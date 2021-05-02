using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Create_Ammo : MonoBehaviour
{
    public GameObject ammo;
    public GameObject barrel;
    public float fire_time = 1f;
    public bool canFire = true;

    // Start is called before the first frame update
    void Start()
    {    }

    // Update is called once per frame
    void Update()
    {
        if (!canFire)
            fire_time -= Time.deltaTime;
        
        if (fire_time <= 0)
        {
            canFire = true;
            fire_time = 1f;
        }

        if (Input.GetKeyDown(KeyCode.Space) && canFire)
        {
            //Instantiate(ammo, new Vector2(barrel.transform.position.x, barrel.transform.position.y), barrel.transform.rotation);
            Instantiate(ammo, new Vector2(barrel.transform.position.x, barrel.transform.position.y), Quaternion.identity);

            canFire = false;
        }

    }
}
