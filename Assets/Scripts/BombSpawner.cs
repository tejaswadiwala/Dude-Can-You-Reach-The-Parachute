using UnityEngine;
using System.Collections;

public class BombSpawner : MonoBehaviour
{

    public Transform[] bombSpawns;
    public GameObject bomb;

    // Use this for initialization
    void Awake()
    {

        Spawn();
    }

    void Spawn()
    {
        for (int i = 0; i < bombSpawns.Length; i++)
        {
            int bombFlip = Random.Range(0, 2);
            if (bombFlip > 0)
                Instantiate(bomb, bombSpawns[i].position, Quaternion.identity);
        }
    }

}