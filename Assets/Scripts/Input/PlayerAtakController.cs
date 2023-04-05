using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;


public class PlayerAtakController : MonoBehaviour
{
    public static event Action OnAtakWeapon;
    public static event Action EndAtakWeapon;

    private Controls _inputs;

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
        _inputs.Player.Atak.performed += Atak_performed;
        _inputs.Player.Atak.canceled += Atak_canceled;
    }
   

    private void Atak_performed(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        OnAtakWeapon?.Invoke();

    }

    private void Atak_canceled(UnityEngine.InputSystem.InputAction.CallbackContext obj)
    {
        EndAtakWeapon?.Invoke();
    }

}
