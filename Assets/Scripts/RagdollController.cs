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

    private void MakeKinematic(bool isKinematic)
    {
        for (int i = 0; i < rigibodyParts.Length; i++)
        {
            rigibodyParts[i].isKinematic = isKinematic;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            MakePhysical();
        }
    }

    private void MakePhysical()
    {
       
            animator.enabled = false;
            MakeKinematic(false);
       
    }
}
