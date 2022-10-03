using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CameraMovement : MonoBehaviour
{
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        LoadCharacter.PlayerSpawedEvent += HandlePlayerSpawnedEvent;
        
        //player = FindObjectOfType<PlayerMovement>().gameObject;
        // player = PlayerPrefs.GetString("selectedCharacter");
    }

    // Update is called once per frame
    void Update()
    {

        if(player != null)
            transform.position = new Vector3(transform.position.x, player.transform.position.y, -10);

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
