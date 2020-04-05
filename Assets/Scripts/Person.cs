using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Person : MapObject
{
    private Material colour;
    private double[] directions = {50,-1,160,-1,50,-1,160,-1};
    private double amountMoved = 0;
    private int movementIndex = 0;

    public Person(GameObject correspondsTo) : base(correspondsTo)
    {
        colour = objectFor.GetComponent<Material>();
    }

    public void move()
    {
        if(amountMoved < directions[movementIndex])
        {
            transform.Translate((float)0.1,0,0);
            Vector3 coords = transform.position;
            coords.x += (float)0.1;
            amountMoved += 0.1;
        }
        else
        {
            amountMoved = 0;
            rotate(directions[movementIndex+1]);
            movementIndex = (movementIndex + 2) % 8;
        }
    }

    public void rotate(double direction)
    {
        transform.Rotate(0,(float)(90*direction),0,Space.Self);
    }
}
