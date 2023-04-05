using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunShotRejectAnimation : MonoBehaviour
{
    private Animator _animShotGunRecoil;
    private void Awake()
    {
        _animShotGunRecoil = gameObject.GetComponent<Animator>();
    }

    private void OnEnable()
    {
        ProjctlShotGun.RealSoundSingleShotWeapon += StartAtak;
    }
    private void OnDisable()
    {
        ProjctlShotGun.RealSoundSingleShotWeapon -= StartAtak;

    }
    private void StartAtak()
    {
        _animShotGunRecoil.SetTrigger("AtakShotGun");
    }


}
