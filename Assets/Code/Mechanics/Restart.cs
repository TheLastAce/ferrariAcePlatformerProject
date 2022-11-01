using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public GameObject StartPoint;
   
    public GameObject Player;

    private GameController gc;
    // Start is called before the first frame update
    void Start()
    {
        LoadCharacter.PlayerSpawedEvent += HandlePlayerSpawnedEvent;
        Player = FindObjectOfType<PlayerMovement>().gameObject;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            print("R");
            Player.transform.position = GameController.Gc.SpawnPos;
        }
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
