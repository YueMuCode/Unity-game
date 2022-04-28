
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addForce : MonoBehaviour
{
    // Start is called before the first frame update
    public float x_power = 0.0f;
    public float y_power = 100.0f;
    Vector2 x_force;

    public addForce()
    {
        x_force = new Vector2(x_power, y_power);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void FixedUpdate()
    {
        
        if (Input.GetMouseButtonDown(0))
        {
            addForce x_addForce = new addForce();
            Rigidbody2D rigidbody = GetComponent<Rigidbody2D>();
            rigidbody.AddForce(x_addForce.x_force);
        }

    }
}
