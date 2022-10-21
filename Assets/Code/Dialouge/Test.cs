using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    DialougeSystem dialouge;
    public DialougeMessage[] myMessages;

    // Start is called before the first frame update
    void Start()
    {
        dialouge = DialougeSystem.instance;
    }

    public string[] s = new string[]
    {
        "hello:cat",
        "I like to draw",
        "cats"
    };

    int i = 0;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
            if(!dialouge.IsSpeaking || dialouge.IsWaitingForInput)
            {
                if (i >= s.Length)
                {
                    return;
                }
                //Say(myMessages[i]); // si senor
                i++;
            }
        }
    }
    void Say(DialougeMessage message)
    {
        
        dialouge.Say(message);

    }
}


