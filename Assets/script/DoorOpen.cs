using UnityEngine;
using UnityEngine.InputSystem; 
public class DoorOpen : MonoBehaviour
{
    public float openAngle = -90f;
    public float openSpeed = 2f;

    private bool open = false;
    private Quaternion targetRotation;

    void Start()
    {
        targetRotation = transform.rotation;
    }

    void Update()
{
    // 按 p 键测试开门
    if (Keyboard.current != null && Keyboard.current.pKey.wasPressedThisFrame)
    {
        OpenDoor();
    }

    if (open)
    {
        transform.rotation = Quaternion.Lerp(
            transform.rotation,
            targetRotation,
            Time.deltaTime * openSpeed
        );
    }
}


    public void OpenDoor()
    {
        open = true;
        targetRotation =
            Quaternion.Euler(0, openAngle, 0) * transform.rotation;
    }
}   

