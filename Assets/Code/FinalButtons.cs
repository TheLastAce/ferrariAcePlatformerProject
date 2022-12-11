using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalButtons : MonoBehaviour
{

    public Sprite MalePicture;
    public Sprite FemalePicture;

    public Image CG;
    int playerCharacter;
    // Start is called before the first frame update
    void Start()
    {
        playerCharacter = PlayerPrefs.GetInt("SelectedCharacter");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetPicture()
    {
        if(playerCharacter == 0)
        {
            CG.sprite = MalePicture;
        }
        if(playerCharacter == 1)
        {
            CG.sprite = FemalePicture;
        }
    }
}
