using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class HoldButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerExitHandler
{
    [SerializeField] float holdTime = 1.5f;   // sekunder man skal holde
    [SerializeField] Image fill;              // cirklen der fylder op
    public UnityEvent onHoldComplete;         // hvad der sker bagefter

    float timer;
    bool holding;

    public void OnPointerDown(PointerEventData e) { holding = true; timer = 0; }
    public void OnPointerUp(PointerEventData e)   => Cancel();
    public void OnPointerExit(PointerEventData e) => Cancel();

    void Cancel()
    {
        holding = false;
        timer = 0;
        if (fill) fill.fillAmount = 0;
    }

    void Update()
    {
        if (!holding) return;
        timer += Time.deltaTime;
        if (fill) fill.fillAmount = timer / holdTime;

        if (timer >= holdTime)
        {
            Cancel();
            onHoldComplete.Invoke();
        }
    }

    void OnDisable() => Cancel();
}