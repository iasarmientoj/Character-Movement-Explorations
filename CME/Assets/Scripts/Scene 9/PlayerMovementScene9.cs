using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovementScene9 : MonoBehaviour
{

    Vector2 moveVector;
    public float moveSpeed = 8f;

    public void InputPlayer(InputAction.CallbackContext _context)
    {
        moveVector = _context.ReadValue<Vector2>();
    }

    void Update()
    {
        Vector3 movement = new Vector3(moveVector.x, 0, moveVector.y);
        movement.Normalize();
        transform.Translate(moveSpeed * movement * Time.deltaTime);
    }
}
