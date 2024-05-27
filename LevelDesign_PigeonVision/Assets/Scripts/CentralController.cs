using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CentralController : MonoBehaviour
{

    [SerializeField] GameObject nyki;
    [SerializeField] GameObject opol;
    [SerializeField] AudioSource ptvamb;
    [SerializeField] AudioSource centralamb;

    private void OnTriggerEnter(Collider other)
    {
        ptvamb.Stop();
        nyki.SetActive(false);
        opol.SetActive(true);
        centralamb.Play();
    }

}
