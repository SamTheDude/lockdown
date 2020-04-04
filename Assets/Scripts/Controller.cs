using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private UserView cameraObject;

    // Start is called before the first frame update
    void Start()
    {
        cameraObject = new UserView("Main Camera");
        Debug.Log(cameraObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("Rotate right");
            cameraObject.rotate(1);
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("Rotate left");
            cameraObject.rotate(-1);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Move right");
            cameraObject.move(1);
        }
        else if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Move left");
            cameraObject.move(-1);
        }
        else if(Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("Zoom in");
            cameraObject.zoom(1);
        }
        else if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("Zoom out");
            cameraObject.zoom(-1);
        }
    }
}
