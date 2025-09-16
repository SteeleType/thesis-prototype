using System.Collections.Generic;
using UnityEngine;

public class SwordSwing : MonoBehaviour
{
    //this script is just to trigger the sword swing
    public Animator animator;
    public DeckManager  deckManager;
    //to see if command can be called 
    public CardManager cardManager;
    
    void Start()
    {
        animator = GetComponent<Animator>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && deckManager.curredntIndex == 0)
        {
            animator.SetTrigger("Swing");
        }

        if (Input.GetKeyDown(KeyCode.Space) && deckManager.curredntIndex == 1)
        {
            animator.SetTrigger("FullSwing");
        }
    }
}
