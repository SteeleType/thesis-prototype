using UnityEngine;

public class SwordSwing : MonoBehaviour
{
    //this script is just to trigger the sword swing
    public Animator animator;


    void Start()
    {
        animator = GetComponent<Animator>();
    }
    // Update is called once per frame
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
