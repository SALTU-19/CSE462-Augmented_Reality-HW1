using UnityEngine;
using UnityEngine.Events;
using Vuforia;

public class jumpZombie : MonoBehaviour
{

    public GameObject vbBtnObj;
    public GameObject zombie;

    // Use this for initialization
    void Start()
    {
        vbBtnObj = GameObject.Find("JumpZombie");
        zombie = GameObject.Find("Zombie1");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);

    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Vector3 temp = new Vector3(0, Time.deltaTime * 1000, 0);
        zombie.transform.position += temp;
        //zombie.transform.Rotate(new Vector3(0, Time.deltaTime * 100000000, 0));
        Debug.Log("Button pressed");
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {

        Debug.Log("Button released");
    }
}