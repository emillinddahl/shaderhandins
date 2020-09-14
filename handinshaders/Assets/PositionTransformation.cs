using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionTransformation : Transformation
{

    public float radius;
    public float speed;
    public bool doOrbit;


    public Vector3 position;


    public override Vector3 Apply (Vector3 point)
    {
        return point + position;
    }



 

    // Update is called once per frame
    void Update()
    {
        if (doOrbit)
        {
            position.x = radius * Mathf.Sin(Time.time * speed);
            position.z = radius * Mathf.Cos(Time.time * speed);
        }
            

        //math equations - make point move in circle



    }
}
