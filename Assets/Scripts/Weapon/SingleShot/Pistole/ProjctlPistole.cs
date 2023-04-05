using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ProjctlPistole : MonoBehaviour
{
    [SerializeField] private GameObject _pistoleWeapon;
    [SerializeField] private float _timeBetwenShot = 0.3f;
    [SerializeField] private int _countPistoleProgectileOnStart;
    [SerializeField] private int _countPistoleProgectile;
    private bool _onTrigerShot;

    public static event Action RealSoundSingleShotWeapon;
    public static event Action FalseSingleShotWeapon;
    public Action<int> CountPistoleProjectile;
    private void OnEnable()
    {
        PlayerAtakController.OnAtakWeapon += ShotPistole;
        PistoleBonusProjectile.OnPistoleBonusProjectile += IncrementBonusProjectile;
    }
    private void OnDisable()
    {
        PlayerAtakController.OnAtakWeapon -= ShotPistole;
        PistoleBonusProjectile.OnPistoleBonusProjectile -= IncrementBonusProjectile;
    }

    void Start()
    {
        _onTrigerShot = false;
        _countPistoleProgectile = _countPistoleProgectileOnStart;
        CountPistoleProjectile?.Invoke(_countPistoleProgectile);
        StartCoroutine(TimerBetwenShot());
    }

    private void OneShot()
    {
        if (!_pistoleWeapon.activeSelf) return;
        if (_countPistoleProgectile > 0)
        {
            _countPistoleProgectile -= 1;
            CountPistoleProjectile?.Invoke(_countPistoleProgectile);
            RealSoundSingleShotWeapon?.Invoke();
        }
        else
        {
            _countPistoleProgectile = 0;
            FalseSingleShotWeapon?.Invoke();
        }
    }
    private void IncrementBonusProjectile()
    {
        _countPistoleProgectile += _countPistoleProgectileOnStart;
        CountPistoleProjectile?.Invoke(_countPistoleProgectile);
    }
    public int ConutPistolCartridges()
    {
        if (_countPistoleProgectile < 0)
        {
            _countPistoleProgectile = 0;

        }

        return _countPistoleProgectile;
    }
    private void ShotPistole()
    {
        _onTrigerShot = true;
        this.InvokeTime(EndShotPistole, _timeBetwenShot);

    }
    private void EndShotPistole()
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
