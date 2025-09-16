using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MagicManager : MonoBehaviour
{
    public Animator fireAnimator;
    public Animator lightningAnimator;
    public DeckManager  deckManager;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && deckManager.curredntIndex == 3)
        {
            fireAnimator.SetTrigger("Fire");
        }

        if (Input.GetKeyDown(KeyCode.Space) &&  deckManager.curredntIndex == 2)
        {
            lightningAnimator.SetTrigger("Lightning");
        }
    }
}

    