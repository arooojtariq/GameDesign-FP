using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FallingLetter : MonoBehaviour
{
    public char letter;
    public TextMeshPro textDisplay;

    void Start()
    {
        textDisplay.text = letter.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            Destroy(this.gameObject);
        }
    }
}
