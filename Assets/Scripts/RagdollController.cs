using System.Collections.Generic;
using UnityEngine;

public class RagdollController : MonoBehaviour
{
    [SerializeField] private Rigidbody[] rigibodyParts;
    [SerializeField] private Animator animator;
    void Awake()
    {
        animator = GetComponent<Animator>();
        rigibodyParts = GetComponentsInChildren<Rigidbody>();
        MakeKinematic(true);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            MakePhysical();
        }
    }

    private void MakeKinematic(bool isKinematic)
    {
        for (int i = 0; i < rigibodyParts.Length; i++)
        {
            rigibodyParts[i].isKinematic = isKinematic;
        }
    }
 

    private void MakePhysical()
    {
       
            animator.enabled = false;
            MakeKinematic(false);
       
    }
}
