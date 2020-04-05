using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MapObject
{
    private Material colour;
    private static float MOVE_DIST = (float)0.1;
    private static float MAX_DIST = 10;

    public Person(GameObject correspondsTo) : base(correspondsTo)
    {
        colour = objectFor.GetComponent<Material>();
    }

    public void move()
    {
        if (!Physics.Raycast(transform.position, transform.TransformDirection(Vector3.right), MAX_DIST))
        {
            transform.Translate(MOVE_DIST,0,0);
            Vector3 coords = transform.position;
            coords.x += MOVE_DIST;
        }
        else
        {
            int direction;
            switch(Random.Range(0,1))
            {
                case 0:
                    direction = 1;
                    break;
                default:
                    direction = -1;
                    break;
            }
            rotate(direction);
        }
    }

    public void rotate(double direction)
    {
        transform.Rotate(0,(float)(90*direction),0,Space.Self);
    }
}
