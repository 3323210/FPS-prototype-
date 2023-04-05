using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ProjctlShotGun : MonoBehaviour
{
    [SerializeField] private GameObject _shotGunWeapon;
    [SerializeField] private float _timeBetwenShot = 1f;
    [SerializeField] private int _countShotGunProgectileOnStart;
    [SerializeField] private int _countShotGunProgectile;
    private bool _onTrigerShot;

    public static event Action RealSoundSingleShotWeapon;
    public static event Action FalseSingleShotWeapon;
    public Action<int> CountShotGunProjectile;

    private void OnEnable()
    {
        PlayerAtakController.OnAtakWeapon += ShotShotGun;
        ShotGunBonusProjectil.OnShotGunProjectile += IncrementBonusProjectile;
    }
    private void OnDisable()
    {
        PlayerAtakController.OnAtakWeapon -= ShotShotGun;
        ShotGunBonusProjectil.OnShotGunProjectile -= IncrementBonusProjectile;
    }

    void Start()
    {
        _onTrigerShot = false;
        _countShotGunProgectile = _countShotGunProgectileOnStart;
        CountShotGunProjectile?.Invoke(_countShotGunProgectile);
        StartCoroutine(TimerBetwenShot());
    }

    private void OneShot()
    {
        if (!_shotGunWeapon.activeSelf) return;
        if (_countShotGunProgectile > 0)
        {
            _countShotGunProgectile -= 1;
            CountShotGunProjectile?.Invoke(_countShotGunProgectile);
            RealSoundSingleShotWeapon?.Invoke();
        }
        else
        {
            _countShotGunProgectile = 0;
            FalseSingleShotWeapon?.Invoke();
        }
    }
    private void IncrementBonusProjectile()
    {
        _countShotGunProgectile += _countShotGunProgectileOnStart;
        CountShotGunProjectile?.Invoke(_countShotGunProgectile);
    }
    public int ConutPistolCartridges()
    {
        if (_countShotGunProgectile < 0)
        {
            _countShotGunProgectile = 0;

        }

        return _countShotGunProgectile;
    }
    private void ShotShotGun()
    {
        _onTrigerShot = true;
        this.InvokeTime(EndShotShotGun, _timeBetwenShot);

    }
    private void EndShotShotGun()
    {
        _onTrigerShot = false;
    }

    IEnumerator TimerBetwenShot()
    {
        while (true)
        {
            yield return new WaitUntil(() => _onTrigerShot);
            OneShot();
            yield return new WaitForSeconds(_timeBetwenShot);
        }

    }
}

