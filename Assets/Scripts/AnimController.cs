using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour
{
    public void startAnim(Animator animator)
    {
        animator.SetTrigger("Start");
    }
    public void stopAnim(Animator animator)
    {
        animator.SetTrigger("Stop");

    }
}
