using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ToggleParticleSystem : MonoBehaviour
{
    private ParticleSystem particleSystem;
    private bool isParticleSystemPlaying = false;

    void Start()
    {
        // Get the ParticleSystem component on this GameObject
        particleSystem = GetComponent<ParticleSystem>();

        // Ensure the Particle System starts in the off state
        if (particleSystem != null)
        {
            particleSystem.Stop();
        }
    }

    void Update()
    {
        // Check for mouse click
        if (Input.GetMouseButton(0))
        {
            // Start the Particle System only if it's not already playing
            if (!isParticleSystemPlaying)
            {
                particleSystem.Play();
                isParticleSystemPlaying = true;
            }
        }
        else
        {
            // Stop the Particle System only if it's currently playing
            if (isParticleSystemPlaying)
            {
                particleSystem.Stop();
                isParticleSystemPlaying = false;
            }
        }
    }
}