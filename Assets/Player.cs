using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    public GameManager wordManager;
    public AudioClip collectSound;

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        transform.position += new Vector3(x, 0, 0) * speed * Time.deltaTime;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        FallingLetter letter = other.GetComponent<FallingLetter>();
        if (letter)
        {
            wordManager.CollectLetter(letter.letter);
            Destroy(other.gameObject);
            AudioSource.PlayClipAtPoint(collectSound, transform.position);
        }
    }
}
