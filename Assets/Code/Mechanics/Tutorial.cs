using TMPro;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public TMP_Text TutorialText;
    public GameObject TutorialCanvas;
    public TMP_Text Prompt;
    public GameObject PromptCanvas;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (GameController.Gc.CurrentLevel.CurrentState == LevelController.LevelState.tutorial)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                TutorialCanvas.SetActive(false);
                PromptCanvas.SetActive(false);
                GameController.Gc.CurrentLevel.CurrentState = LevelController.LevelState.gameplay;
            }
        }
    }
}
