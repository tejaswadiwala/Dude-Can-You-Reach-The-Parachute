using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinScript : MonoBehaviour
{
    public static int coinValue = 0;
    Text coins;

    // Start is called before the first frame update
    void Start()
    {
        coins = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        coins.text = "Coins: " + coinValue;
    }


}
