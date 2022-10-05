using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour
{
    public GameObject StartPoint;
    public GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        LoadCharacter.PlayerSpawedEvent += HandlePlayerSpawnedEvent;
        //player = FindObjectOfType<PlayerMovement>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
            Player.transform.position = StartPoint.transform.position;
    }
    public void HandlePlayerSpawnedEvent(GameObject chosenPlayer)
    {
        Player = chosenPlayer;
    }

    public void OnDestroy()
    {
        LoadCharacter.PlayerSpawedEvent -= HandlePlayerSpawnedEvent;
    }
}
