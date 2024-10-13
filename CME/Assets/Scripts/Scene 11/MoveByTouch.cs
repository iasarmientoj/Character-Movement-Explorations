using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveByTouch : MonoBehaviour
{

    [SerializeField] private bool moverPlayer;
    [SerializeField] private bool verTouches;


    void Update()
    {
        if (moverPlayer)
            MoverPlayer();

        if (verTouches)
            VerTouches();
    }

    private void MoverPlayer()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0;
            transform.position = touchPosition;
        }
    }

    private void VerTouches()
    {
        for (int i = 0; i < Input.touchCount; i++)
        {

             Vector3 touchPosition = Camera.main.ScreenToWorldPoint(Input.touches[i].position);
             Debug.DrawLine(Vector3.zero, touchPosition, Color.red);

        }
    }
}
