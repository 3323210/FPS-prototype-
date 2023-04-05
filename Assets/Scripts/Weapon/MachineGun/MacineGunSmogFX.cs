using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MacineGunSmogFX : MonoBehaviour
{
    [SerializeField] private GameObject _FXShotSmog;
    [SerializeField] private float _timeBetvenShot = 0.05f;
    private void OnEnable()
    {
        ProjctlMachineGun.OnShotBoletTrue += ShotPistoleSmogStart;
        ProjctlMachineGun.OnShotBoletFalse += FalseShotPistol;
    }
    private void OnDisable()
    {
        ProjctlMachineGun.OnShotBoletTrue -= ShotPistoleSmogStart;
        ProjctlMachineGun.OnShotBoletFalse -= FalseShotPistol;
    }

    private void Awake()
    {
        _FXShotSmog.SetActive(false);
    }

    private void ShotPistoleSmogStart()
    {
        ShowSmogShotPistol();
        this.InvokeTime(FalseShotPistol, _timeBetvenShot);
    }
    private void FalseShotPistol()
    {
        _FXShotSmog.SetActive(false);
    }
    private void ShowSmogShotPistol()
    {
        _FXShotSmog.SetActive(true);
    }
}