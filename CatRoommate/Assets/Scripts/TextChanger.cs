using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextChanger : MonoBehaviour
{
    public TextMeshProUGUI crunchy;
    public string[] crunchyStuff;

    public void ChangeText()
    {
        int randNum;
        randNum = Random.Range(0, crunchyStuff.Length);
        crunchy.text = crunchyStuff[randNum];
    }
}
