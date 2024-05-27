using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartIntro : MonoBehaviour
{

    [SerializeField] AudioSource startamb;
    [SerializeField] GameObject[] windows;
    [SerializeField] GameObject[] trains;
   
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        startamb.Play();
        StartCoroutine(intro(12));
    }

    IEnumerator intro(float delay)
    {
        yield return new WaitForSeconds(delay);
        trains[0].SetActive(false);
        trains[1].SetActive(true);
        trains[2].SetActive(true);
        windows[0].SetActive(false);
        windows[1].SetActive(false);
        windows[2].SetActive(false);
        windows[3].SetActive(false);
        windows[4].SetActive(false);
        windows[5].SetActive(false);
    }

    


    
}
