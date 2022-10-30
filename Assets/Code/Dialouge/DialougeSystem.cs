using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialougeSystem : MonoBehaviour
{
    public static DialougeSystem instance;

    public GameObject SpeechPanel;
    public TMP_Text SpeakerNameText;
    public TMP_Text SpeechText;

    public bool IsWaitingForInput = false;
    Coroutine Speaking = null;
    private void Awake()
    {
        instance = this;
    }

    // Start is called before the first frame update
    void Start()
    {

    }
    public void Say(DialougeMessage message)
    {
        StopSpeaking();
        Speaking = StartCoroutine(speaking(message.Message, message.Speaker));
    }
    public void StopSpeaking()
    {
        if (Speaking != null)
        {

            SpeakerNameText.text = "";
            SpeechText.text = "";
            StopCoroutine(Speaking);

            Speaking = null;
        }
    }
    /*if(Speaking != null)
        {
        IsSpeaking = true;
        }*/


    IEnumerator speaking(string targetSpeech, string speaker)
    {
        SpeechPanel.SetActive(true);
        SpeechText.text = "";
        SpeakerNameText.text = speaker;
        IsWaitingForInput = false;

        while (SpeechText.text != targetSpeech)
        {
            SpeechText.text += targetSpeech[SpeechText.text.Length];
            yield return new WaitForSeconds(.05f);
        }
        IsWaitingForInput = true;
        while (IsWaitingForInput)
        {
            yield return new WaitForEndOfFrame();
        }
        StopSpeaking();
    }
 
}

//  public class Elements





