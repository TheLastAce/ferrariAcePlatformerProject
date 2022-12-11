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
            //Player.transform.position = GameController.Gc.SpawnPos;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        if (Input.GetKey(KeyCode.Escape))

        {

            Application.Quit();

        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            print("2");
            SceneManager.LoadScene("level2");
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            print("3");
            SceneManager.LoadScene("level3");
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            print("4");
            SceneManager.LoadScene("End");
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
