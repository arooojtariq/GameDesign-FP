using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public string[] words = { "CAT", "SEA", "MAN", "FISH", "BOOK","CHEF","CAMERA","MOUSE","PENCIL" };
    public Sprite[] pictures;
    public Image targetImage;
    public TextMeshProUGUI progressText;
    public Scoring Scores;

    int wordIndex = 0;
    int letterIndex = 0;

    public AudioClip nextLetter;
    void Start()
    {
        LoadWord();
    }

    public char GetNextLetter()
    {
        return words[wordIndex][letterIndex];
    }

    public void CollectLetter(char c)
    {
        if (c == GetNextLetter())
        {
            letterIndex++;
            UpdateProgress();

            if (letterIndex >= words[wordIndex].Length)
            {
                NextWord();
                Scores.count += 10;
                Scores.updateScore();
                
            }
        }
    }

    void LoadWord()
    {
        targetImage.sprite = pictures[wordIndex];
        letterIndex = 0;
        UpdateProgress();
    }

    void UpdateProgress()
    {
        string display = "";
        for (int i = 0; i < words[wordIndex].Length; i++)
        {
            display += (i < letterIndex) ? words[wordIndex][i] + " " : "_ ";
        }
        progressText.text = display;
    }

    void NextWord()
    {
        wordIndex++;
        if (wordIndex >= words.Length) wordIndex = 0;
        AudioSource.PlayClipAtPoint(nextLetter, transform.position);
        LoadWord();
        
    }
}
