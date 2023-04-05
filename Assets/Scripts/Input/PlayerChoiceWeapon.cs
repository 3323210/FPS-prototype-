using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerChoiceWeapon : MonoBehaviour
{
    private Controls _inputs;

    public static event Action choiceKnife;
    public static event Action choicePistole;
    public static event Action choiceShotGun;
    public static event Action choiceMachineGun;
    private void Awake()
    {
        _inputs = new Controls();
    }
    private void OnEnable()
    {
        _inputs.Enable();
    }
    private void OnDisable()
    {
        _inputs.Disable();
    }

    private void Start()
    {
        _inputs.Player.WeaponKnife.performed += WeaponKnife_performed;
        _inputs.Player.WeaponGun.performed += WeaponGun_performed;
        _inputs.Player.WeaponShotGun.performed += WeaponShotGun_performed;
        _inputs.Player.WeaponMachineGun.performed += WeaponMachineGun_performed;
    }

    private void WeaponKnife_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        choiceKnife?.Invoke();
    }

    private void WeaponGun_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        choicePistole?.Invoke();
    }

    private void WeaponShotGun_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        choiceShotGun?.Invoke();
    }

    private void WeaponMachineGun_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        choiceMachineGun?.Invoke();
    }

}