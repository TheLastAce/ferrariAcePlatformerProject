using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartBoss : MonoBehaviour
{
    public GameObject Dragon;
    public TMP_Text Run;
    public GameObject VNRoot;

    public AudioSource DragonSound;
    public AudioClip Roar;
    public AudioClip Roar2;
    public AudioClip BossMusic;
    public AudioClip RestMusic;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Run.enabled = true;
        Dragon.SetActive(true);
        if (GameController.Gc.CurrentLevel.CurrentState == LevelController.LevelState.gameplay)
        {
            if (GameController.Gc.Music.clip != BossMusic)
            {
                GameController.Gc.Music.Stop();
                GameController.Gc.Music.clip = BossMusic;
                GameController.Gc.Music.Play();
                DragonSound.PlayOneShot(Roar);
            }
        }
        if(GameController.Gc.CurrentLevel.CurrentState == LevelController.LevelState.dialogue)
        {
            
        }
        
    }
}
