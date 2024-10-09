using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCamera : MonoBehaviour
{
    public float Yaxis;
    public float Xaxis;
    public float RotationSensitivity = 8f;
    public bool enableMobileInputs = false;


    float RotationMin = -40f;
    float RotationMax = 80f;
    float smoothTime = 0.12f;


    public Transform target;
    Vector3 targetRotation;
    Vector3 currentVel;
    public FixedTouchField touchField;
    private void Start()
    {
        if (enableMobileInputs)
            RotationSensitivity = 0.2f;
    }

    void LateUpdate()

    {

        Vector2 input = Vector2.zero;
        if (enableMobileInputs)
        {
            Yaxis += touchField.TouchDist.x * RotationSensitivity;
            Xaxis -= touchField.TouchDist.y * RotationSensitivity;
        }
        else
        {
            Yaxis += Input.GetAxis("Mouse X") * RotationSensitivity;
            Xaxis -= Input.GetAxis("Mouse Y") * RotationSensitivity;
        }

        Xaxis = Mathf.Clamp(Xaxis, RotationMin, RotationMax);


        targetRotation = Vector3.SmoothDamp(targetRotation, new Vector3(Xaxis, Yaxis), ref currentVel, smoothTime);
        transform.eulerAngles = targetRotation;


        transform.position = target.position - transform.forward * 2f;

    }
}
