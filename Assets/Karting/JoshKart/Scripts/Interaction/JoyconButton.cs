using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

[RequireComponent(typeof(Button))]
public class JoyconButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler {

    private bool _buttonPressed;

    public bool IsPressed => this._buttonPressed;

    public void OnPointerDown(PointerEventData eventData)
    {
        this._buttonPressed = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        this._buttonPressed = false;
    }
}