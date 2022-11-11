using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMovement : MonoBehaviour
{
    float xRotation;
    float yRotation;

    float xRotationCurrent;
    float yRotationCurrent;

    float smoothTime = 0.1f;
    float currentVelosityX;
    float currentVelosityY;

    public Camera player_camera;
    public GameObject playerGameObject;
    public float sensivity = 5f;

    void MouseMove()
    {
        xRotation += Input.GetAxis("Mouse X")* sensivity;
        yRotation += Input.GetAxis("Mouse Y")* sensivity;

        xRotationCurrent = Mathf.SmoothDamp(xRotation,xRotationCurrent, ref currentVelosityX, smoothTime);
        yRotationCurrent = Mathf.SmoothDamp(yRotation,yRotationCurrent, ref currentVelosityY, smoothTime);

        player_camera.transform.rotation = Quaternion.Euler(-yRotationCurrent,xRotationCurrent,0f);
        playerGameObject.transform.rotation = Quaternion.Euler(0f,xRotation,0f);
    }
    void Update()
    {
        MouseMove();
    }

}
