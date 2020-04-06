using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private UserView[] views = new UserView[2];
    private ArrayList dots = new ArrayList(100);
    private ArrayList objects = new ArrayList(100);
    private Person person;

    private int currentView;
    
    // Start is called before the first frame update
    public void Start()
    {
        views[0] = new UserView("StaticViewPoint");
        views[1] = new UserView("RoamViewPoint");
        currentView = 0;
        GameObject person1 = GameObject.Find("Person");
        person = new Person(person1);
    }

    // Update is called once per frame
    public void Update()
    {
        changeViews();
        moveView();
        moveCounters();
    }

    public void changeViews()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            switch(currentView)
            {
                case 0:
                    views[0].changeState(false);
                    views[1].changeState(true);
                    currentView = 1;
                    break;
                case 1:
                    views[0].changeState(true);
                    views[1].changeState(false);
                    currentView = 0;
                    break;
            }
        }
    }

    public void moveCounters()
    {
        person.move();
    }

    public void moveView()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            views[currentView].rotate(1);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            views[currentView].rotate(-1);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            views[currentView].move(1);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            views[currentView].move(-1);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            views[currentView].zoom(1);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            views[currentView].zoom(-1);
        }
    }
}