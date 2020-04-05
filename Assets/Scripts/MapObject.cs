using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapObject
{
    protected GameObject objectFor;
    protected Transform transform;

    public MapObject(GameObject objectFor)
    {
        this.objectFor = objectFor;
        transform = this.objectFor.GetComponent<Transform>();
    }
}
