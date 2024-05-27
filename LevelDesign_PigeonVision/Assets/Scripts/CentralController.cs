using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CentralController : MonoBehaviour
{
    //This is the main switch script that is triggered when the player gets the train and enters the first station
    //It's basic function is to swap transit cards and station sounds

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
