using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private UserView[] views = new UserView[2];
    private ArrayList dots = new ArrayList(100);
    private ArrayList objects = new ArrayList(100);
    private Person person;

    private int currentView = 0;
    
    // Start is called before the first frame update
    public void Start()
    {
        views[0] = new Aerial("StaticViewPoint");
        views[1] = new Roam("RoamViewPoint");
        GameObject person1 = GameObject.Find("Person");
        person = new Person(person1);
        for(int i = 1; i < views.Length; i++)
        {
            views[i].changeState(false);
        }
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
            views[currentView].changeState(false);
            currentView = (currentView + 1)%2;
            views[currentView].changeState(true);
        }
    }

    public void moveCounters()
    {
        person.move();
    }

    public void moveView()
    {
        UserView view = views[currentView];
        if (Input.GetKey(KeyCode.UpArrow))
        {
            moveCamera(view, 1);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            moveCamera(view, -1);
        }
        else if(Input.GetKey(KeyCode.LeftArrow))
        {
            moveCamera(view,2);
        } 
        else if(Input.GetKey(KeyCode.RightArrow))
        {
            moveCamera(view, 3);
        }
        else
        {
            zoomCamera(view);
        }
    }

    public void moveCamera(UserView view, int direction)
    {
        if (view is Roam)
        {
            Roam roamer = (Roam)view;
            if(direction == 2)
            {
                roamer.rotate(-1);
            }
            else if(direction == 3)
            {
                roamer.rotate(1);
            }
            else
            {
                roamer.move(direction);
            }
        }
        else if (view is Aerial)
        {
            Aerial aerial = (Aerial)view;
            if (direction == 2)
            {
                aerial.move(4);
            }
            else if (direction == 3)
            {
                aerial.move(2);
            }
            else
            {
                aerial.move(direction);
            }
        }
    }

    public void zoomCamera(UserView view)
    {
        if (Input.GetKey(KeyCode.W))
        {
            view.zoom(1);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            view.zoom(-1);
        }
    }
}