using UnityEngine;

public class MichelleController : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }
    private void SetAnimation(string triggerName, bool isDancing)
    {
        animator.SetTrigger(triggerName);
        animator.SetBool("IsDancing", isDancing);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            ResetAnimation();
            SetAnimation("CatWalk", false);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            ResetAnimation();
            SetAnimation("Dance", false);
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            ResetAnimation();
            SetAnimation("Dance", true);
        }
    }
    private void ResetAnimation()
    {
        animator.ResetTrigger("CatWalk");
        animator.ResetTrigger("Dance");
        animator.SetBool("IsDancing", false);
    }
}