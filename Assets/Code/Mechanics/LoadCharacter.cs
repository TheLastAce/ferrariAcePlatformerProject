using System;
using UnityEngine;

public class LoadCharacter : MonoBehaviour
{
    public GameObject[] CharacterPrefabs;
    public Transform SpawnPoint;
    public static Action<GameObject> PlayerSpawedEvent;

    private GameController gc;
    //public TMP_Text label;

    private void Start()
    {
        gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();
        if (gc.CheckPointPos != null)
            SpawnPoint.position = gc.CheckPointPos;
        int SelectedCharacter = PlayerPrefs.GetInt("SelectedCharacter");
        GameObject prefab = CharacterPrefabs[SelectedCharacter];
        GameObject clone = Instantiate(prefab, SpawnPoint.position, Quaternion.identity);
        clone.SetActive(true);
        PlayerSpawedEvent?.Invoke(clone);
        //label.text = prefab.name;



    }
}
