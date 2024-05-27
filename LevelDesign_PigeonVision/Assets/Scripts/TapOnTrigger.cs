using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapOnTrigger : MonoBehaviour
{
    //This controls the interaction at the gates between the Sydney station and the Tokyo stations

    [SerializeField] Animator anim;
    [SerializeField] AudioSource animSound;
    [SerializeField] string triggerName;
    [SerializeField] bool triggered = false;

    private void OnMouseDown()
    {
        if(triggered == false)
        {
            //if u click down on the ticket gate, a sound and animation is triggered.
            triggered = true;
            animSound.Play();
            anim.GetComponent<Animator>().SetTrigger(triggerName);
        }
    }
}
