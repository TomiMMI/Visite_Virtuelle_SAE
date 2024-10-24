using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    [SerializeField]private ConfigurableJoint cameraRigidBody;
    private Vector3 lastMousePosition;
    private Vector3 nextRotateValue;
    void Start()
    {
    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0))
        {
            nextRotateValue = Input.mousePosition - lastMousePosition;
            lastMousePosition = Input.mousePosition;
        }
    }
    private void LateUpdate()
    {
       /* Vector3 cameraLimits = Vector3.zero;
        if(cameraRigidBody.transform.eulerAngles.x < 250f && cameraRigidBody.transform.eulerAngles.x > 95f)
        {
            cameraLimits.x = 250f;
        }
        else if(cameraRigidBody.transform.eulerAngles.x < 245f && cameraRigidBody.transform.eulerAngles.x > 90f)
        {
            cameraLimits.x = 90f;
        }
        else
        {
            cameraLimits.x = cameraRigidBody.transform.eulerAngles.x;
        }
        cameraLimits.y = cameraRigidBody.transform.eulerAngles.y;
        cameraRigidBody.transform.eulerAngles = cameraLimits;*/
    }
}
