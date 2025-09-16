using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MagicManager : MonoBehaviour
{
    public Animator fireAnimator;
    public Animator lightningAnimator;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            fireAnimator.SetTrigger("Fire");
        }

        if (Input.GetKeyDown(KeyCode.L))
        {
            lightningAnimator.SetTrigger("Lightning");
        }
    }
}

    