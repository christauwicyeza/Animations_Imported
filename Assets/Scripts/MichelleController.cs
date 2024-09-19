using UnityEngine;

public class MichelleController : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.C))
            animator.SetTrigger("CatWalk");

        if (Input.GetKeyDown(KeyCode.D))
            animator.SetTrigger("Dance");
    }
}
