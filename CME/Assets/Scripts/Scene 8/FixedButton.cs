using UnityEngine;
using UnityEngine.EventSystems;

public class FixedButton : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    [HideInInspector]
    public bool Pressed;


    [SerializeField] private Animator animator;



    public void OnPointerDown(PointerEventData eventData)
    {
        Pressed = true;
        animator.SetTrigger("jump");
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Pressed = false;
        animator.ResetTrigger("jump");
    }
}