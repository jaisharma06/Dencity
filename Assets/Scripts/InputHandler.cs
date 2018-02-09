using System.Collections;
using UnityEngine;

public class InputHandler : MonoBehaviour
{

    [SerializeField]
    private float holdTimeMin = 0.3f;

    private bool isHolding = false;

    void Update()
    {
        HandleInput();
    }

    private void HandleInput()
    {
        if (Input.touchCount > 0)
        {
            var touch = Input.GetTouch(0);
            switch (touch.phase)
            {
                case TouchPhase.Began:
                    EventManager.CallOnTriggerDown();
                    StartCoroutine(ActivateHold(true));
                    break;
                case TouchPhase.Moved:
                    break;
                case TouchPhase.Ended:
                    EventManager.CallOnTriggerUp();
                    isHolding = false;
                    break;
            }

            if (isHolding)
            {
                EventManager.CallOnTriggerHold();
            }
        }
    }

    private IEnumerator ActivateHold(bool flag)
    {
        yield return new WaitForSeconds(holdTimeMin);
        isHolding = flag;
    }
}
