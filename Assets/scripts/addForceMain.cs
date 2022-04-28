using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addForceMain : MonoBehaviour
{
    // Start is called before the first frame update
    public float x_power = 0.0f;
    public float y_power = 100.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate()
    {

        if (Input.GetButtonDown("Jump"))
        {
            Force x_force = new Force(x_power, y_power);
            Rigidbody2D rigidbody2D = GetComponent<Rigidbody2D>();
            rigidbody2D.AddForce(x_force.Do());
        }

    }
}
