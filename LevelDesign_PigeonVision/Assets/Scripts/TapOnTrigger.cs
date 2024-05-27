using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapOnTrigger : MonoBehaviour
{
    [SerializeField] Animator anim;
    [SerializeField] AudioSource animSound;
    [SerializeField] string triggerName;
    [SerializeField] bool triggered = false;

    private void OnMouseDown()
    {
        if(triggered == false)
        {
            triggered = true;
            animSound.Play();
            anim.GetComponent<Animator>().SetTrigger(triggerName);
        }
    }
}
