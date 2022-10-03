using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelect : MonoBehaviour
{
    public GameObject[] characters;
    public int selectedCharacter = 0;
    

    public void NextCharacter()
    {
        characters[selectedCharacter].SetActive(false);
        selectedCharacter = (selectedCharacter + 1) % characters.Length;
        characters[selectedCharacter].SetActive(true);
    }

    public void PreviousCharacter()
    {
        characters[selectedCharacter].SetActive(false);
        selectedCharacter--;

        if (selectedCharacter < 0)
            selectedCharacter += characters.Length;
        characters[selectedCharacter].SetActive(true);
    }

    public void StartGame()
    {
        PlayerPrefs.SetInt("selectedCharacter", selectedCharacter);
        SceneManager.LoadScene("level1");
    }
}
/*
 * why does the character select only change the prefab and not the gameObject?
 * How do I assign the player game object to scripts through code?
 * How do I assign scripts to a gameObject through code?
 * fix camera movement
 */
