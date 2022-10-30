using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    DialougeSystem dialouge;
    public DialougeMessage[] MyMessages;

    // Start is called before the first frame update
    void Start()
    {
        dialouge = DialougeSystem.instance;
    }


    int i = 0;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Return))
        {
          
                if (i >= MyMessages.Length)
                {
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


