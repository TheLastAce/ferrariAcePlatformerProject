using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Test : MonoBehaviour
{
    DialougeSystem dialouge;
    public DialougeMessage[] MyMessages;

    
    string sceneName;

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
        if(Input.GetKeyDown(KeyCode.Return))
        {
          
                if (i >= MyMessages.Length - 1)
                {
                if (sceneName == "level1")
                {
                    SceneManager.LoadScene("level2");
                }
                if (sceneName == "level2")
                {
                    SceneManager.LoadScene("level3");
                }
                //load scene
                return;
                }
                Say(MyMessages[i]); 
                i++;
            
        }
        

    }
    void Say(DialougeMessage message)
    {
        dialouge.Say(message);
    }
}


