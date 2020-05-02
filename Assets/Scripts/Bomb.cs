using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Bomb : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            CoinScript.coinValue =0;
            SceneManager.LoadScene("Level 1");    
        }
    }

}