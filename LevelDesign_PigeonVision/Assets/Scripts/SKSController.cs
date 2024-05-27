using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SKSController : MonoBehaviour
{
    [SerializeField] AudioSource platformAmb;

    private void OnTriggerEnter(Collider other)
    {
        platformAmb.Play();
    }
}
