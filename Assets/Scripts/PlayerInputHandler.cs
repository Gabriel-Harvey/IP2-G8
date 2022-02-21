using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputHandler : MonoBehaviour
{
    Movement player;
    CharacterSwitcher switcher;
    public List<GameObject> players = new List<GameObject>();

    void Start()
    {
        switcher = GameObject.FindGameObjectWithTag("InputManager").GetComponent<CharacterSwitcher>();
        player = GameObject.Instantiate(players[switcher.index], transform.position, transform.rotation).GetComponent<Movement>();
    }

    public void Move(InputAction.CallbackContext context)
    {
        if (player)
        {
            player.NewMove(context.ReadValue<Vector2>().x);
        }
    }

    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed && Mathf.Abs(player._rigidbody.velocity.y) < 0.01f)
        {
            player.LargeJump();
        }

        if (context.canceled && Mathf.Abs(player._rigidbody.velocity.y) > 0f)
        {
            player.SmallJump();
        }

    }


}
