using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashDetector : MonoBehaviour
{
    public ParticleSystem ExplosionParticle;
    public airtimescore GameOverScript;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("obstacle"))
        {
            ExplosionParticle.Play();
            GameOverScript.GameOver();

        }
    }
}

