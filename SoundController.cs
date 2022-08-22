﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
    public AudioSource wallSound;
    public AudioSource racketSound;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "RacketPlayer1" || collision.gameObject.name == "RacketPlayer2")
        {
            this.racketSound.Play();
            Debug.Log("Racket Hit");
        }
        else
            this.wallSound.Play();
    }
}
