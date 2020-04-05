using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MapObject
{
    private BoxCollider collider;

    public Building(GameObject correspondsTo) : base(correspondsTo)
    {
        collider = objectFor.GetComponent<BoxCollider>();
    }
}
