using UnityEngine;

public class HumanoidController : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
       
        animator = GetComponent<Animator>();
    }

    void Update()
    {
       
        if (Input.GetKey(KeyCode.W))
        {
            animator.SetBool("IsWalking", true);
        }
        else
        {
            animator.SetBool("IsWalking", false);
        }


    }
}
