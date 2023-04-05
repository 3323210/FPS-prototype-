using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ProjctlMachineGun : MonoBehaviour
{
    [SerializeField] private GameObject _machineGun;
    [SerializeField] private float _timeBetwenShot = 0.25f;
    [SerializeField] private int _countMachineGunProgectileOnStart;
    [SerializeField] private int _countMachineGunProgectile;
    private bool _onTrigerShot;

    public static event Action OnShotBoletTrue;
    public static event Action OnShotBoletFalse;

    public Action<int> CountMashineGunProjectile;

    private void OnEnable()
    {
        MachineGunBonusProjectil.OnMachineGunProjectile += IncrementBonusProjectile;
        PlayerAtakController.OnAtakWeapon += ShotMachineGun;
        PlayerAtakController.EndAtakWeapon += EndShotMachineGun;
    }
    private void OnDisable()
    {
        MachineGunBonusProjectil.OnMachineGunProjectile -= IncrementBonusProjectile;
        PlayerAtakController.OnAtakWeapon -= ShotMachineGun;
        PlayerAtakController.EndAtakWeapon -= EndShotMachineGun;
    }
    void Start()
    {
        _onTrigerShot = false;
        StartCoroutine(TimerBetwenShot());
        _countMachineGunProgectile = _countMachineGunProgectileOnStart;
        CountMashineGunProjectile?.Invoke(_countMachineGunProgectile);
    }

    private void IncrementBonusProjectile()
    {
        _countMachineGunProgectile += _countMachineGunProgectileOnStart;
        CountMashineGunProjectile?.Invoke(_countMachineGunProgectile);

    }
    private void OneShot()
    {
        if (_machineGun.activeSelf)
        {
           

            if (_countMachineGunProgectile > 0)
            { 
                _countMachineGunProgectile -= 1;
                OnShotBoletTrue?.Invoke();
                CountMashineGunProjectile?.Invoke(_countMachineGunProgectile);
            }

            else
            {
                _countMachineGunProgectile = 0; 
                OnShotBoletFalse?.Invoke();

            }
                
        }

    }
    private void ShotMachineGun()
    {
        _onTrigerShot = true;
    }
    private void EndShotMachineGun()
    {
        _onTrigerShot = false;
    }
    public int ConutMashineGunCartridges()
    {
        if (_countMachineGunProgectile <= 0)
        {
            _countMachineGunProgectile = 0;
        }
        return _countMachineGunProgectile;
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
