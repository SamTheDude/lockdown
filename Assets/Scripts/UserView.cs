using UnityEngine;

public abstract class UserView
{
    protected GameObject viewObject;
    protected Transform cameraTransform;
    protected Vector3 position;

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

    public abstract void move(int direction);
}
