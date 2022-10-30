using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterSelectII : MonoBehaviour
{
    public GameObject[] Characters;
    public int SelectedCharacter = 0;

    public void Male()
    {
        SelectedCharacter = 0;
        Characters[SelectedCharacter].SetActive(true);
    }

    public void Female()
    {
        SelectedCharacter = 1;
        Characters[SelectedCharacter].SetActive(true);
    }
    public void StartGame()
    {
        PlayerPrefs.SetInt("selectedCharacter", SelectedCharacter);
        SceneManager.LoadScene("level1");
    }
}
