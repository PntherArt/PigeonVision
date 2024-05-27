using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpCard : MonoBehaviour
{
    //The player "picks" up the transport card on the floor and it swaps out the opol card to the "suica" card

    [SerializeField] GameObject opol;
    [SerializeField] GameObject lightSwitch;
    public Transform theDest;

    private void OnMouseDown()
    {
        opol.SetActive(false);
        lightSwitch.SetActive(false);
        this.transform.position = theDest.position;
        this.transform.parent = GameObject.Find("Destination").transform;
    }
}
