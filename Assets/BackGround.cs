using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGround : MonoBehaviour
{
    public Scoring scoreScript;       
    public SpriteRenderer background;     
    public Sprite background30;       
    public Sprite background60;       
    public Sprite background90;       

    void Update()
    {
        int score = scoreScript.count;

        if (score >= 90)
        {
            background.sprite = background90;
        }
        else if (score >= 60)
        {
            background.sprite = background60;
        }
        else if (score >= 30)
        {
            background.sprite = background30;
        }
    }
}
