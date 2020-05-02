using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public static AudioClip coinSound;
    static AudioSource audioSource;

    void Start()
    {

        coinSound = Resources.Load<AudioClip>("coin");

        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {

            case "coin":
                audioSource.PlayOneShot(coinSound);
                break;

        }
    }
}
