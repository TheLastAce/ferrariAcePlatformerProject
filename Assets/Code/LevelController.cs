using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
    public enum LevelState
    {
        tutorial, 
        gameplay,
        dialogue
    }
    public LevelState CurrentState;
    public Restart RestartInstance;
    public DialougeSystem DialougeSystemInstance;
    public LoadCharacter LoadCharacterInstance;
    public Test TestInstance;
    public Tutorial TutorialInstance;

    // Start is called before the first frame update
    void Start()
    {
        GameController.Gc.CurrentLevel = this;
        GameController.Gc.SpawnPos = RestartInstance.StartPoint.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
