using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSingleShotSmogFX : MonoBehaviour
{
    [SerializeField] private GameObject _FXShotSmog;

    [SerializeField] private float _timeBetvenShot = 0.2f;
    private void OnEnable()
    {
        ProjctlPistole.RealSoundSingleShotWeapon += ShotPistoleSmogStart;
        ProjctlPistole.FalseSingleShotWeapon += FalseShotPistol;
    }
    private void OnDisable()
    {
        ProjctlPistole.RealSoundSingleShotWeapon -= ShotPistoleSmogStart;
        ProjctlPistole.FalseSingleShotWeapon -= FalseShotPistol;
    }

    private void Awake()
    {
        _FXShotSmog.SetActive(false);
    }
    
    private void ShotPistoleSmogStart()
    {
        ShowSmogShotPistol();
        this.InvokeTime(FalseShotPistol, _timeBetvenShot );
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