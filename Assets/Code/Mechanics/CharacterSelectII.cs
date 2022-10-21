using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelectII : MonoBehaviour
{
    public GameObject[] characters;
    public int selectedCharacter = 0;

    public void Male()
    {
        selectedCharacter = 0;
        characters[selectedCharacter].SetActive(true);
    }

    public void Female()
    {
        selectedCharacter = 1;
        characters[selectedCharacter].SetActive(true);
    }
    public void StartGame()
    {
        PlayerPrefs.SetInt("selectedCharacter", selectedCharacter);
        SceneManager.LoadScene("level1");
    }
}
