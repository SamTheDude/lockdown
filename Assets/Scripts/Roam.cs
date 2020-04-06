using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roam : UserView
{
    public Roam(string name) : base(name) { }

    public override void move(int direction)
    {
        cameraTransform.Translate(0, direction, direction);
        position.y += direction;
        position.z = position.z - direction;
    }

    public void rotate(int direction)
    {
        cameraTransform.Rotate(-40, 0, 0, Space.Self);
        cameraTransform.Rotate(0, direction, 0, Space.Self);
        cameraTransform.Rotate(40, 0, 0, Space.Self);
    }
}
