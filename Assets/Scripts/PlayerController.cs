using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 3.0F;
    public float rotateSpeed = 3.0F;
    float inputValueX;
    float inputValueY;
    CharacterController characterController;
    public Animator animator;
    void Awake()
    {
        characterController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }


    void Update()
    {
        inputValueX = Input.GetAxis("Horizontal");
        inputValueY = Input.GetAxis("Vertical");
        Vector3 forward = transform.TransformDirection(Vector3.forward);
        transform.Rotate(0, inputValueX * rotateSpeed, 0);
        float curSpeed = speed * inputValueY;
        characterController.SimpleMove(forward * curSpeed);
        if (inputValueY > 0)
        {
            animator.SetInteger("walk", 1);
        }
        if (inputValueY < 0)
        {
            animator.SetInteger("walk", 2);
        }


    }

    private void FixedUpdate()
    {
        if (characterController != null)
        {
            characterController.Move(new Vector3(inputValueX, 0, inputValueY));
        }
    }
}
