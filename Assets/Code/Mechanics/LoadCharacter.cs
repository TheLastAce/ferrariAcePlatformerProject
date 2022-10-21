using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class LoadCharacter : MonoBehaviour
{
    public GameObject[] CharacterPrefabs;
    public Transform SpawnPoint;
    public static Action<GameObject>PlayerSpawedEvent;
    //public TMP_Text label;

    private void Start()
    {
        int SelectedCharacter = PlayerPrefs.GetInt("SelectedCharacter");
        GameObject prefab = CharacterPrefabs[SelectedCharacter];
        GameObject clone = Instantiate(prefab, SpawnPoint.position, Quaternion.identity);
        clone.SetActive(true);
        PlayerSpawedEvent?.Invoke(clone);
        //label.text = prefab.name;
    }
}
