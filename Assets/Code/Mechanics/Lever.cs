using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public GameObject Button;
    public GameObject Door;
    public GameObject ConnectedDoor;
    public bool DoorIsOpen;
    public bool TouchButton;

    public AudioClip Click;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        TouchButton = true;
    }
    public void OnTriggerExit2D(Collider2D collision)
    {
        TouchButton = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && TouchButton == true)
        {
            AudioSource.PlayClipAtPoint(Click, Camera.main.transform.position);

            if (DoorIsOpen == false)
            {
                Door.SetActive(false); //open door
                ConnectedDoor.SetActive(true); //close connected
                DoorIsOpen = true; //set main door open
            }
            else if (DoorIsOpen == true)
            {
                Door.SetActive(true);
                ConnectedDoor.SetActive(false);
                DoorIsOpen = false;
            }
        }
    }
}
//why you no work? >:(
