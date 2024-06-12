using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandSteer : MonoBehaviour
{
    public Transform leftHandle;
    public Transform rightHandle;
    private Animator animator;


    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void OnAnimatorIK()
    {
        if (leftHandle)
        {
            animator.SetIKPosition(AvatarIKGoal.LeftHand, leftHandle.transform.position);
            animator.SetIKPositionWeight(AvatarIKGoal.LeftHand, 1.0f);

            animator.SetIKRotation(AvatarIKGoal.LeftHand, leftHandle.transform.rotation);
            animator.SetIKRotationWeight(AvatarIKGoal.LeftHand, 1.0f);
        }
        if (rightHandle)
        {
            animator.SetIKPosition(AvatarIKGoal.RightHand, rightHandle.transform.position);
            animator.SetIKPositionWeight(AvatarIKGoal.RightHand, 1.0f);

            animator.SetIKRotation(AvatarIKGoal.RightHand, rightHandle.transform.rotation);
            animator.SetIKRotationWeight(AvatarIKGoal.RightHand, 1.0f);
        }
    }
}

