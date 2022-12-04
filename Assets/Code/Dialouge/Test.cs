using UnityEngine;
using UnityEngine.SceneManagement;

public class Test : MonoBehaviour
{
    DialougeSystem dialouge;
    public DialougeMessage[] MyMessages;


    string sceneName;
    GameObject choicePanel;

    public AudioSource Level;
    public AudioClip Click;
    // Start is called before the first frame update
    void Start()
    {
        Scene currentScene = SceneManager.GetActiveScene();
        dialouge = DialougeSystem.instance;
        sceneName = currentScene.name;
    }


    int i = 0;
    // Update is called once per frame
    void Update()
    {
        if (GameController.Gc.CurrentLevel.CurrentState == LevelController.LevelState.dialogue)
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {

                if (i >= MyMessages.Length)
                {
                    if (sceneName == "Intro")
                    {
                        SceneManager.LoadScene("level1");
                    }
                    if (sceneName == "level1")
                    {
                        SceneManager.LoadScene("level2");
                    }
                    if (sceneName == "level2")
                    {
                        SceneManager.LoadScene("level3");
                    }
                    if (sceneName == "level3")
                    {
                        SceneManager.LoadScene("end");
                    }
                    if (sceneName == "End")
                    {
                        // choicePanel.SetActive(true);
                        SceneManager.LoadScene(0);
                    }
                    //load scene
                    return;
                }
                Say(MyMessages[i]);
                Level.PlayOneShot(Click);
                i++;

            }
        }


    }
    void Say(DialougeMessage message)
    {
        dialouge.Say(message);
    }
}


