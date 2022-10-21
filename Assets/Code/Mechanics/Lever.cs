using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public GameObject Button;
    public GameObject Door;
    public GameObject ConnectedDoor;
    public bool doorIsOpen;
    public bool touchButton;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        touchButton = true;
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        touchButton = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && touchButton == true)
        {
            if (doorIsOpen == false)
            {
                Door.SetActive(false); //open door
                ConnectedDoor.SetActive(true); //close connected
                doorIsOpen = true; //set main door open
            }
            else if (doorIsOpen == true)
            {
                Door.SetActive(true);
                ConnectedDoor.SetActive(false);
                doorIsOpen = false;
            }
        }
    }
}
//why you no work? >:(
