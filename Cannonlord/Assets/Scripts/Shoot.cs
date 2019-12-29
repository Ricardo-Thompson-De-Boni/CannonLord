using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject project;
    public float power;
    public Transform firepoint;
    public float cooldownTime;
    float time;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (time > 0f)
        {
            time -= Time.deltaTime;
        }
        else
        {
            if (Input.GetMouseButtonDown(0))
            {
                time = cooldownTime;
                GameObject projf = (GameObject)Instantiate(project, firepoint.position, firepoint.rotation);
                projf.GetComponent<Rigidbody>().velocity = firepoint.forward * power;
            }
        }
    }
}
