using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRotationScript : MonoBehaviour
{
    [SerializeField]
    float xySense,zoomSense;
    float sense;

    private void Start()
    {
        sense = xySense;
    }

    void Update()
    {
        if (Input.GetButton("Fire2"))
        {
            transform.RotateAround(Vector3.zero, transform.up, sense * Input.GetAxisRaw("Mouse X"));
            transform.RotateAround(Vector3.zero, transform.right, -sense * Input.GetAxisRaw("Mouse Y"));
        }
        float mouseWheelIn = Input.GetAxisRaw("Mouse ScrollWheel");
        if (mouseWheelIn != 0)
        {
            Vector3 aux = transform.position + transform.forward * mouseWheelIn * zoomSense;
            float auxMag = aux.magnitude;
            if (auxMag > 820) aux = aux.normalized * 820;
            else if (auxMag < 400) aux = aux.normalized * 400;
            transform.position = aux;

            sense = Mathf.Pow(Mathf.InverseLerp(0, 820, auxMag) , 3) * xySense;
        }
    }

    public void resetNorth()
    {
        transform.rotation = Quaternion.LookRotation(-transform.position, Vector3.up);
    }
}
