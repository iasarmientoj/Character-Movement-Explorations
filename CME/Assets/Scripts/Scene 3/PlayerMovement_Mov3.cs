using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement_Mov3 : MonoBehaviour
{
    private CharacterController characterController;

    public Animator animator;

    public new Transform camera;
    public float speed = 4;
    public float gravity = -9.8f;


    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        
    }

    // Update is called once per frame
    void Update()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        Vector3 movement = Vector3.zero;

        float movementSpeed = 0;

        if(hor != 0 || ver != 0)
        {
            Vector3 forward = camera.forward;
            forward.y = 0;
            forward.Normalize();

            Vector3 right = camera.right;
            right.y = 0;
            right.Normalize();


            Vector3 direction = forward * ver + right * hor;
            movementSpeed = Mathf.Clamp01(direction.magnitude);
            direction.Normalize();

            movement = direction * speed * movementSpeed * Time.deltaTime;

            //para que el personaje gire en el sentido del movimiento
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(direction), 0.2f);

        }

        movement.y += gravity * Time.deltaTime;

        characterController.Move(movement);

        animator.SetFloat("Speed", movementSpeed);

    }
}
