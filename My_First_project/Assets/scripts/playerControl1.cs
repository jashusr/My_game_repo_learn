using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl1 : MonoBehaviour
{
    public float horizontalSpeed = 2.0F;
    public float verticalSpeed = 2.0F;
    void Update()
    {
        float h = horizontalSpeed * Input.GetAxis("Mouse X");
        transform.Rotate(0, h, 0);
    }
}