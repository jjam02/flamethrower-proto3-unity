using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ToggleParticleSystem : MonoBehaviour
{


    void Start()
    {
        // Get the ParticleSystem component on this GameObject


        // Ensure the Particle System starts in the off state
        if (GetComponent<ParticleSystem>() != null)
        {
            GetComponent<ParticleSystem>().Stop();
        }
    }

    void Update()
    {
        // Check for mouse click
        if (Input.GetMouseButtonDown(0))
        {
            // Start the Particle System only if it's not already playing
            // if (!isParticleSystemPlaying)
            // {
            //     particleSystem.Play();
            //     isParticleSystemPlaying = true;
            // }
            GetComponent<ParticleSystem>().Play();
        }
        else if (Input.GetMouseButtonUp(0))
        {
            // Stop the Particle System only if it's currently playing
            // if (isParticleSystemPlaying)
            // {
            //     particleSystem.Stop();
            //     isParticleSystemPlaying = false;
            // }
            GetComponent<ParticleSystem>().Clear();
            GetComponent<ParticleSystem>().Stop();
        }
    }
}