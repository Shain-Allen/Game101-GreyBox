using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TiltControl : MonoBehaviour
{
    public Transform cameraAnchor;

    public Vector3 camStart;
    public float cameraSpeed = 0.5f;
    public float tiltSpeed = 0.3f;
    Vector2 tiltDirRaw;
    Vector2 tiltDir;
    Vector2 camMoveRaw;
    Vector2 camMove;

    void Start()
    {
        transform.rotation = Quaternion.Euler(0,0,0);
        cameraAnchor.rotation = Quaternion.Euler(camStart);
    }

    void Update()
    {
        tiltDir = tiltDirRaw * tiltSpeed;
        transform.rotation *= Quaternion.Euler(tiltDir.y, 0, -tiltDir.x);

        camMove = camMoveRaw * cameraSpeed;
        //float x = cameraAnchor.rotation.x;
        //float y = cameraAnchor.rotation.y;
        //float z = cameraAnchor.rotation.z;

        //Vector3 desiredRot = new Vector3(x, y + camMove.x, z);

        //cameraAnchor.rotation = Quaternion.Euler();   
    }

    public void TableMovement(InputAction.CallbackContext ctx)
    {
        if(ctx.performed)
        {
            tiltDirRaw = ctx.ReadValue<Vector2>();
        }
        else
        {
            tiltDirRaw = new Vector2(0,0);
        }
    }

    public void CameraMovement(InputAction.CallbackContext ctx)
    {
        camMoveRaw = ctx.ReadValue<Vector2>();
    }
}
