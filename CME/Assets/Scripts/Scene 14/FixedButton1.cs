using UnityEngine;
using UnityEngine.EventSystems;

public class FixedButton1 : MonoBehaviour, IPointerUpHandler, IPointerDownHandler
{
    public bool Pressed;
    public bool PressedDown;
    public bool PressedUp;


    public void OnPointerDown(PointerEventData eventData)
    {
        Pressed = true;
        PressedDown = true;
        Invoke(nameof(ReleaseDown),0.1f);
        PressedUp = false;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        Pressed = false;
        PressedDown = false;
        PressedUp = true;
        Invoke(nameof(ReleaseUp), 0.1f);
    }

    private void ReleaseDown()
    {
        PressedDown = false;
    }

    private void ReleaseUp()
    {
        PressedUp = false;
    }

}