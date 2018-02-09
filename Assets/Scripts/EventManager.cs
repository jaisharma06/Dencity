using System;

public class EventManager
{
    public static Action OnTriggerDown;
    public static Action OnTriggerUp;
    public static Action OnTriggerHold;
    public static Action OnTriggerClick;

    public static void CallOnTriggerDown()
    {
        if (OnTriggerDown != null)
        {
            OnTriggerDown();
        }
    }

    public static void CallOnTriggerUp()
    {
        if (OnTriggerUp != null)
        {
            OnTriggerUp();
        }
    }

    public static void CallOnTriggerHold()
    {
        if (OnTriggerHold != null)
        {
            OnTriggerHold();
        }
    }

    public static void CallOnTriggerClick()
    {
        if (OnTriggerClick != null)
        {
            OnTriggerClick();
        }
    }
}
