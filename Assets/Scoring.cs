using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scoring : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI score;
    public int count;
    void Start()
    {
        count = 0;
        updateScore();
    }

    public void updateScore(){
        score.text=""+count.ToString();

     }
}
