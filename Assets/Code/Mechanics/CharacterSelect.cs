using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelect : MonoBehaviour
{
    public GameObject[] Characters;
    public int SelectedCharacter = 0;
    

    public void NextCharacter()
    {
        Characters[SelectedCharacter].SetActive(false);
        SelectedCharacter = (SelectedCharacter + 1) % Characters.Length;
        Characters[SelectedCharacter].SetActive(true);
    }

    public void PreviousCharacter()
    {
        Characters[SelectedCharacter].SetActive(false);
        SelectedCharacter--;

        if (SelectedCharacter < 0)
            SelectedCharacter += Characters.Length;
        Characters[SelectedCharacter].SetActive(true);
    }

    public void StartGame()
    {
        PlayerPrefs.SetInt("SelectedCharacter", SelectedCharacter);
        SceneManager.LoadScene("Intro");
    }
}
/*
 * why does the character select only change the prefab and not the gameObject?
 * How do I assign the player game object to scripts through code?
 * How do I assign scripts to a gameObject through code?
 * fix camera movement
 */
