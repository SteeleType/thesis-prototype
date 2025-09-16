using System;
using UnityEngine;

public class SupportManager : MonoBehaviour
{
    public Animator wallAnimator;
    public DeckManager deckManager;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && deckManager.curredntIndex == 4)
        {
            wallAnimator.SetTrigger("Wall");
        }
    }
}
