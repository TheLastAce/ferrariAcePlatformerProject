using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static GameController Gc;
    DialougeSystem dialougeSystem;
    Test testInstance;
    public LevelController CurrentLevel;

    public AudioSource Music;

    public Vector3 SpawnPos;
    // Start is called before the first frame update
    void Start()
    {
        //dialougeSystem.enabled = false;
        // testInstance.enabled = false;
        if (Gc == null)
        {
            Gc = this;
        }
        else
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   /* private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            CheckPointPos
            //SceneManager.LoadScene("level3");
        }
    }*/
}
