using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineGunShotRejectAnimation : MonoBehaviour
{
    private Animator _animMashinGunRecoil;
    private void Awake()
    {
        _animMashinGunRecoil = gameObject.GetComponent<Animator>();
    }
    
    private void OnEnable()
    {
        PlayerAtakController.OnAtakWeapon += StartReject;
        PlayerAtakController.EndAtakWeapon += StopReject;
    }
    private void OnDisable()
    {
        PlayerAtakController.OnAtakWeapon -= StartReject;
        PlayerAtakController.EndAtakWeapon -= StopReject;

    }
    private void StartReject()
    {
        _animMashinGunRecoil.SetTrigger("AtakMachineGun");
    }

    private void StopReject()
    {
        _animMashinGunRecoil.SetTrigger("EndAtakMachineGun");

    }
}
