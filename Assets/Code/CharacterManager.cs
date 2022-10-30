using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
/*
public class CharacterManager : MonoBehaviour
{
    public static CharacterManager Instance;

    public RectTransform CharacterPanel;

    public List<Characters> Character = new List<Characters>();

    public Dictionary<string, int> CharacterDict = new Dictionary<string, int>();


    public void Awake()
    {
        Instance = this;
    }

    public Characters GetCharacter(string characterName, bool createCharacter = true)
    {
        int i = -1;
        if (CharacterDict.TryGetValue(characterName, out i))
        {
            return Character[i];
        }
        else if (createCharacter)
        {
            return CreateCharacter(characterName);
        }
        return null;

    }
    public Characters CreateCharacter(string characterName)
    {
        Characters newCharacter = new Characters(characterName);

        CharacterDict.Add(characterName, Character.Count);
        Character.Add(newCharacter);


        return newCharacter;
    }
}*/
