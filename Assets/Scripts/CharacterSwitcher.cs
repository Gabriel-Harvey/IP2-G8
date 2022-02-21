using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CharacterSwitcher : MonoBehaviour
{
    public int index = 0;
    public void SwitchCharacterSpawn(PlayerInput input)
    {
        StartCoroutine(WaitTimerCourotine());      
    }

    IEnumerator WaitTimerCourotine()
    {
        yield return new WaitForSeconds(0.1f);
        index = 1;
    }

}
