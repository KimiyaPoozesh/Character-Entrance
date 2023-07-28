using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    public ParticleSystem particleSystem;

    public GameObject knife,bow,att;

    void Start()
    {
        // Get the ParticleSystem component attached to this object
        particleSystem = GetComponent<ParticleSystem>();
    }
    public void knifeATT()
    {
        Debug.Log("here");
        knife.SetActive(true);
        particleSystem.Play();
        StartCoroutine(DeactivateKnife());

    }

    public void bowATT(){
        Instantiate(att, bow.transform.position, bow.transform.rotation);
    }

    IEnumerator DeactivateKnife()
    {
        // Wait for the particle system to finish playing
        yield return new WaitForSeconds(particleSystem.main.duration);
        // Deactivate the knife GameObject
        knife.SetActive(false);
    }
}
