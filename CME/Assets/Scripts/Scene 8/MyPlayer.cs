using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPlayer : MonoBehaviour
{
    public float MoveSpeed = 3f;
    public float smoothRotationTime = 0.25f;
    public bool enableMobileInputs = false;


    float currentVeclocity;
    float currentSpeed;
    float speedVelocity;


    Transform cameraTransform;
    public FixedJoystick joystick;

    private void Start()
    {
        cameraTransform = Camera.main.transform;

    }

    void Update()
    {
        Vector2 input = Vector2.zero;
        if (enableMobileInputs)
        {
            input = new Vector2(joystick.Horizontal, joystick.Vertical);
        }
        else
        {
            input = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        }
        Vector2 inputDir = input.normalized;

        if (inputDir != Vector2.zero)
        {
            float rotation = Mathf.Atan2(inputDir.x, inputDir.y) * Mathf.Rad2Deg + cameraTransform.eulerAngles.y;
            transform.eulerAngles = Vector3.up * Mathf.SmoothDampAngle(transform.eulerAngles.y, rotation, ref currentVeclocity, smoothRotationTime);
        }

        float tragetSpeed = MoveSpeed * inputDir.magnitude;
        currentSpeed = Mathf.SmoothDamp(currentSpeed, tragetSpeed, ref speedVelocity, 0.1f);


        if (inputDir.magnitude > 0)
        {
            GetComponent<Animator>().SetBool("running", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("running", false);
        }

            transform.Translate(transform.forward * (currentSpeed) * Time.deltaTime, Space.World);

    }
}
