using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SKSController : MonoBehaviour
{
    //This is a simple trigger to turn on the SKS audio that happens when a player walks through the platform entrance to the last train

    [SerializeField] AudioSource platformAmb;

    private void OnTriggerEnter(Collider other)
    {
        platformAmb.Play();
    }
}
