using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public void ProcessDie() {
        Animator animator = GetComponentInChildren<Animator>();
        animator.CrossFade("FallDown", 0f);
    }
}
