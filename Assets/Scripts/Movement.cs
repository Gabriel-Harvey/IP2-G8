using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    

    [Header("Movement")]
    public float movementSpeed;
    public float jumpForce;
    public float horizontal;
    public Rigidbody2D _rigidbody;

    private bool isFacingRight = true;
    

    private void FixedUpdate()
    {
        _rigidbody.velocity = new Vector2(horizontal * movementSpeed, _rigidbody.velocity.y);

        if (!isFacingRight && horizontal > 0f)
        {
            flip();
        }
        else if (isFacingRight && horizontal < 0f)
        {
            flip();
        }



    }

    private void flip()
    {
        isFacingRight = !isFacingRight;
        Vector3 localScale = transform.localScale;
        localScale.x *= -1f;
        transform.localScale = localScale;
    }

    /*public void Move(InputAction.CallbackContext context)
    {
        horizontal = context.ReadValue<Vector2>().x;
    }*/

    /*public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed && Mathf.Abs(_rigidbody.velocity.y) < 0.01f)
        {
            _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, jumpForce);
        }

        if (context.canceled && _rigidbody.velocity.y > 0f)
        {
            _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, _rigidbody.velocity.y * 0.5f);
        }
        
    }*/

    public void LargeJump()
    {
        _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, jumpForce);
    }

    public void SmallJump()
    {
        _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, _rigidbody.velocity.y * 0.5f);
    }

    public void NewMove(float value)
    {
        horizontal = value;
    }


}
