using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Knife : MonoBehaviour
{
    [SerializeField] protected float _damageWeapon = 0.2f;
    private bool _boolAtak;

    public static event Action KnifefAtakTrue;
    public static event Action KnifeAtakFalse;

    protected virtual void OnEnable()
    {
        PlayerAtakController.OnAtakWeapon += StartDamage;
        PlayerAtakController.EndAtakWeapon += EndDamage;
    }
    protected virtual void OnDisable()
    {
        PlayerAtakController.OnAtakWeapon -= StartDamage;
        PlayerAtakController.EndAtakWeapon -= EndDamage; ;
    }

    private void Start()
    {
        _boolAtak = false;
    }
    
    private void StartDamage()
    { 
        _boolAtak = true;
        KnifeAtakFalse?.Invoke();
      
    }
    private void EndDamage()
    {
        _boolAtak = false;
    }
    protected void Accept(IWeaponVisitor weaponVisitor, float damageWeapon)
    {
        weaponVisitor.Visit(this, _damageWeapon);

    }
    private void OnTriggerEnter(Collider enemy)
    {
        var colliderGameObj = enemy.gameObject;

        if (!colliderGameObj.TryGetComponent(out IWeaponVisitor weaponVisitor)) return;
        if (!_boolAtak) return;
        KnifefAtakTrue?.Invoke();
        Accept(weaponVisitor, _damageWeapon);

    }

}