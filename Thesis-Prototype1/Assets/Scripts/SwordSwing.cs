using System.Collections.Generic;
using UnityEngine;

public class SwordSwing : MonoBehaviour
{
    //this script is just to trigger the sword swing
    public Animator animator;
    
    //to see if command can be called 
    public CardManager cardManager;
    
    void Start()
    {
        animator = GetComponent<Animator>();
        cardManager.cards = new List<Card>();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetTrigger("Swing");
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            animator.SetTrigger("FullSwing");
        }
    }
}
