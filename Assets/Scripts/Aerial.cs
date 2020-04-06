using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aerial : UserView
{
    public Aerial(string name) : base(name) { }

    public override void move(int direction)
    {
        float[] directions = new float[2];
        switch(direction)
        {
            case 1:
                directions[1] = 1;
                break;
            case 2:
                directions[0] = 1;
                break;
            case -1:
                directions[1] = -1;
                break;
            case 4:
                directions[0] = -1;
                break;
        }
        cameraTransform.Translate(directions[0],directions[1],0);
        position.x += directions[0];
        position.y += directions[1];
    }
}
