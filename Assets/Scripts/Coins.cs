﻿using UnityEngine;
using System.Collections;

public class Coins : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            Destroy(gameObject);
            CoinScript.coinValue += 1;
            SoundManagerScript.PlaySound("coin");

        }

    }
}