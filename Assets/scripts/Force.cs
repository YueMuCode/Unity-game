using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Force 
{
    // Start is called before the first frame update



    private Vector2 x_force;

    public Force(float x,float y)
    {
        x_force = new Vector2(x,y);
    }
    public Vector2 Do()
    {
        return x_force;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
