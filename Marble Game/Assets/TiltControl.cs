using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TiltControl : MonoBehaviour
{

    public float TiltSpeed = 0.3f;
    Vector2 TiltDirRaw;
    Vector2 TiltDir;

    void Start()
    {
        transform.rotation = Quaternion.Euler(0,0,0);
    }

    void Update()
    {
        TiltDir = TiltDirRaw * TiltSpeed;
        transform.rotation *= Quaternion.Euler(TiltDir.y, 0, -TiltDir.x);
    }

    public void TableMovement(InputAction.CallbackContext ctx)
    {
        if(ctx.performed)
        {
            TiltDirRaw = ctx.ReadValue<Vector2>();
        }
        else
        {
            TiltDirRaw = new Vector2(0,0);
        }
    }
}
