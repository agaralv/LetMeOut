using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Letter : MonoBehaviour
{
    public string lower;
    public string upper;
    public string alt;

    private void Start()
    {
        ShowLetter();
    }
    public void OnClic()
    {
        if (LetterManager.lm.alt)
            LetterManager.lm.AddLetter(alt);
        else if (LetterManager.lm.shift)
            LetterManager.lm.AddLetter(upper);
        else
            LetterManager.lm.AddLetter(lower);
    }

    public void ShowLetter()
    {
        if (LetterManager.lm.alt)
            GetComponentInChildren<Text>().text = alt;
        else if (LetterManager.lm.shift)
            GetComponentInChildren<Text>().text = upper;
        else
            GetComponentInChildren<Text>().text = lower;
    }
}
