using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StartBoss : MonoBehaviour
{
    public GameObject Dragon;
    public TMP_Text Run;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Run.enabled = true;
        Dragon.SetActive(true);
    }
}
