using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private UserView viewPoint;
    private ArrayList dots = new ArrayList(100);
    private ArrayList objects = new ArrayList(100);
    private Person person;
    
    // Start is called before the first frame update
    public void Start()
    {
        viewPoint = new UserView("ViewPoint");
        GameObject person1 = GameObject.Find("Person");
        person = new Person(person1);
    }

    // Update is called once per frame
    public void Update()
    {
        moveView();
        moveCounters();
    }

    public void moveCounters()
    {
        person.move();
    }

    public void moveView()
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
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            viewPoint.move(-1);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            viewPoint.zoom(1);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            viewPoint.zoom(-1);
        }
    }
}