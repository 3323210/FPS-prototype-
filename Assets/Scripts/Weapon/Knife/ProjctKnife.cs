using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ProjctKnife : MonoBehaviour
{
 /*   [SerializeField] private GameObject _machineGun;
    [SerializeField] private float _timeBetwenShot = 0.25f;
    [SerializeField] private int _countMachineGunProgectileOnStart;
    private int _countMachineGunProgectile;
    private bool _onTrigerShot;

    public static event Action OnShotBoletTrue;
    public static event Action OnShotBoletFalse;

    private void OnEnable()
    {
        MachineGunBonusProjectil.OnMachineGunProjectile += IncrementProjectile;
        PlayerFireController.OnShotWeapon += ShotMachineGun;
        PlayerFireController.EndShotWeapon += EndShotMachineGun;
    }
    private void OnDisable()
    {
        MachineGunBonusProjectil.OnMachineGunProjectile -= IncrementProjectile;
        PlayerFireController.OnShotWeapon -= ShotMachineGun;
        PlayerFireController.EndShotWeapon -= EndShotMachineGun;
    }
    void Start()
    {
        _onTrigerShot = false;
        StartCoroutine(TimerBetwenShot());
        _countMachineGunProgectile = _countMachineGunProgectileOnStart;
    }

    private void IncrementProjectile()
    {
        _countMachineGunProgectile += _countMachineGunProgectileOnStart;

    }
    private void OneShot()
    {
        if (_machineGun.activeSelf)
        {
           

            if (_countMachineGunProgectile > 0)
            { 
                _countMachineGunProgectile -= 1;
                OnShotBoletTrue?.Invoke();
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

    }*/
}
