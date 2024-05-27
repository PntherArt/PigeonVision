using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpCard : MonoBehaviour
{
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
