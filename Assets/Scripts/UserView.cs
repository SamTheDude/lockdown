using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserView
{
    private Transform cameraTransform;
    private Vector3 position;

    public UserView(string cameraName)
    {
        cameraTransform = GameObject.Find(cameraName).GetComponent<Transform>();
        position = cameraTransform.position;
        Debug.Log("(" + position.x + "," + position.y + "," + position.z + ")");
    }

    public void move(int direction)
    {
        float movedBy = direction /* Time.deltaTime*/;
        cameraTransform.Translate(movedBy,0,0);
        position.x += movedBy;
        Debug.Log("(" + position.x + "," + position.y + "," + position.z + ")");
    }

    public void rotate(int direction)
    {
        cameraTransform.Rotate(0, direction /* Time.deltaTime*/, 0,Space.Self);
    }

    public void zoom(int direction)
    {
        float movedBy = direction /* Time.deltaTime*/;
        cameraTransform.Translate(0, movedBy, 0);
        position.y += movedBy;
        Debug.Log("(" + position.x + "," + position.y + "," + position.z + ")");
    }
}
