using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCameraMovement : MonoBehaviour
{
    public float RotationSpeed = 1f;
    public Transform target, player;
    float mouseX, mouseY;

    private void LateUpdate()
    {
        CamControl();

    }
    private void CamControl()
    {
        mouseX += Input.GetAxis("Mouse X") * RotationSpeed;
        mouseY -= Input.GetAxis("Mouse Y") * RotationSpeed;
        mouseY = Mathf.Clamp(mouseY, -35, 60);

        transform.LookAt(target);
        //target.rotation = Quaternion.Euler(mouseY, mouseX, 0);
        player.rotation = Quaternion.Euler(0, mouseX, 0);

    }
}
