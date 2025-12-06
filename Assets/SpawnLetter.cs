using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SpawnLetter : MonoBehaviour
{
    public GameObject letterPrefab;
    public float minX = -3f;
    public float maxX = 3f;
    public float spawnTime = 1f;

    public GameManager wordManager;

    void Start()
    {
        InvokeRepeating("Spawn", 1f, spawnTime);
    }

    void Spawn()
    {
        GameObject l = Instantiate(letterPrefab);
        float x = Random.Range(minX, maxX);
        l.transform.position = new Vector3(x, transform.position.y, 0);

        // assign letter
        char needed = wordManager.GetNextLetter();
        char randomLetter = (char)Random.Range('A', 'Z' + 1);

        // 5% correct letter, 50% random
        char finalLetter = Random.value < 0.5f ? needed : randomLetter;

        l.GetComponent<FallingLetter>().letter = finalLetter;
        l.GetComponent<FallingLetter>().textDisplay =l.GetComponentInChildren<TextMeshPro>();
    }
}
