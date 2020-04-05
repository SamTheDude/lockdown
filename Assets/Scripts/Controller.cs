using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private UserView viewPoint;
    private int zoomDir, moveDir, rotateDir;
    private ArrayList dots = new ArrayList(100);
    
    // Start is called before the first frame update
    void Start()
    {
        viewPoint = new UserView("ViewPoint");
        Debug.Log(viewPoint);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            viewPoint.rotate(1);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            viewPoint.rotate(-1);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            viewPoint.move(1);
        }
        else if(Input.GetKey(KeyCode.DownArrow))
        {
            viewPoint.move(-1);
        }
        else if(Input.GetKey(KeyCode.W))
        {
            viewPoint.zoom(1);
        }
        else if(Input.GetKey(KeyCode.S))
        {
            viewPoint.zoom(-1);
        }
    }
}