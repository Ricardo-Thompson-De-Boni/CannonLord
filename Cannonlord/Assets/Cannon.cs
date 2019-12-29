using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bullet;
    public float power = 20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("f"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject proj = Instantiate(bullet, firePoint.position, firePoint.rotation);
        Rigidbody2D rb = proj.GetComponent<Rigidbody2D>();
        rb.AddForce(firePoint.up * power, ForceMode2D.Impulse);
    }
}
