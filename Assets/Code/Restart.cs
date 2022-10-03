using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour
{
    public GameObject startPoint;
    public GameObject player;
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
            player.transform.position = startPoint.transform.position;
    }
    public void HandlePlayerSpawnedEvent(GameObject chosenPlayer)
    {
        player = chosenPlayer;
    }

    public void OnDestroy()
    {
        LoadCharacter.PlayerSpawedEvent -= HandlePlayerSpawnedEvent;
    }
}
