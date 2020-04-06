using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserView
{
    private GameObject viewObject;
    private Transform cameraTransform;
    private Vector3 position;

    public UserView(string name)
    {
        viewObject = GameObject.Find(name);
        cameraTransform = viewObject.GetComponent<Transform>();
        position = cameraTransform.position;
    }

    public void changeState(bool active)
    {
        viewObject.SetActive(active);
    }

    public void zoom(int direction)
    {
        cameraTransform.Translate(0,0,direction);
        position.z += direction;
    }

    public void rotate(int direction)
    {
        cameraTransform.Rotate(-40,0,0,Space.Self);
        cameraTransform.Rotate(0, direction, 0, Space.Self);
        cameraTransform.Rotate(40, 0, 0, Space.Self);
    }

    public void move(int direction)
    {
        cameraTransform.Translate(0, direction, direction);
        position.y += direction;
        position.z = position.z - direction;
    }
}
