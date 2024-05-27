using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SKSDoor : MonoBehaviour
{
    [SerializeField] AudioSource JPNamb;
    [SerializeField] AudioSource ENGamb;
    [SerializeField] AudioSource AnnAmb;
    [SerializeField] GameObject[] windows;
    [SerializeField] GameObject[] trains;
    [SerializeField] GameObject EndingScene;
 

    private void OnTriggerEnter(Collider other)
    {
        //This function happens when the player walks through the train door. It triggers the coroutines
        AnnAmb.Stop();
        JPNamb.Play();
        StartCoroutine(intro(1));
        StartCoroutine(english(15));
        StartCoroutine(bye(32));
        
    }

    IEnumerator intro(float delay)
    {
        //this function changes the 3d models of the train so that it uses the inside with windows rather than an empty object. 
        yield return new WaitForSeconds(delay);
        trains[0].SetActive(false);
        trains[1].SetActive(false);
        trains[2].SetActive(true);
        windows[0].SetActive(true);
        windows[1].SetActive(true);
        windows[2].SetActive(true);
        windows[3].SetActive(true);
        windows[4].SetActive(true);
        windows[5].SetActive(true);
    }

    IEnumerator english(float delay)
    {
        //this simply runs the english announcement audio
        yield return new WaitForSeconds(delay);
        ENGamb.Play();
    }

    IEnumerator bye(float delay)
    {
        //this sets the exit canvas active
        yield return new WaitForSeconds(delay);
        EndingScene.SetActive(true);

    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            //this allows the player to exit the game in the train.
            Application.Quit();
            Debug.Log("Quit!");
        }
    }


}
