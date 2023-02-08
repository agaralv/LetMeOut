using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LetterManager : MonoBehaviour
{
    public string word = "";
    public bool shift = false;
    public bool alt = false;
    public Text boxWord;
    public static LetterManager lm;
    Letter[] letter;

    private void Awake()
    {
        lm = this;
        letter = GetComponentsInChildren<Letter>();
    }
    public void AddLetter(string letter)
    {
        word += letter;
        boxWord.text = word;
    }

    public void PushMayus()
    {
        shift = !shift;
        for (int i = 0; i < letter.Length; i++)
        {
            letter[i].ShowLetter();
        }
    }

    public void PushAlt()
    {
        alt = !alt;
        for (int i = 0; i < letter.Length; i++)
        {
            letter[i].ShowLetter();
        }
    }
}
