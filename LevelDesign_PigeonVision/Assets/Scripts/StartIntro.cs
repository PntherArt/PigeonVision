using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartIntro : MonoBehaviour
{
    //This runs the intro when the game is loaded. This lasts for about 12 seconds.

    [SerializeField] AudioSource startamb;
    [SerializeField] GameObject[] windows;
    [SerializeField] GameObject[] trains;
   
    void Start()
    {
        //this starts the sound effects and locks the cursor to get ready for the intro
        Cursor.lockState = CursorLockMode.Locked;
        startamb.Play();
        StartCoroutine(intro(12));
    }

    IEnumerator intro(float delay)
    {
        //this swaps the gameobjects so that the train can be exited and the game can start.
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
