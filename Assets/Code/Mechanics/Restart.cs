using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    public GameObject StartPoint;
    public GameObject CheckPoint;
    public GameObject Player;

    private GameController gc;
    // Start is called before the first frame update
    void Start()
    {
        LoadCharacter.PlayerSpawedEvent += HandlePlayerSpawnedEvent;
        //player = FindObjectOfType<PlayerMovement>().gameObject;
        gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        transform.position = gc.CheckPointPos;
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
