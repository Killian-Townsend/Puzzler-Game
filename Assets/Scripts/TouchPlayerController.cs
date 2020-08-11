using UnityEngine;

public class TouchPlayerController : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        //Move Front/Back
        if (MobileJoystick_UI.instance.moveDirection.y != 0)
        {
            transform.Translate(transform.forward * Time.deltaTime * 8f * MobileJoystick_UI.instance.moveDirection.y, Space.World);
        }

        //Rotate Left/Right
        if (MobileJoystick_UI.instance.moveDirection.x != 0)
        {
            transform.Rotate(new Vector3(0, 14, 0) * Time.deltaTime * 3f * MobileJoystick_UI.instance.moveDirection.x, Space.Self);
        }
    }
}