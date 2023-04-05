using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class EnemyLv1 : MonoBehaviour, IWeaponVisitor
{
    private Rigidbody _rigidbody;
    [SerializeField] private Transform _camera;
    [SerializeField] private float _destroyTime = 5;
    [SerializeField] protected GameObject _hitBlodPreset;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _rigidbody.useGravity = false;
    }

    public void Visit(Knife weapon, float damage)
    {
        Debug.Log("kn");
        _rigidbody.useGravity = true;
        AddForceToItem(damage);
        this.InvokeTime(DestroyEnemy, _destroyTime);
    }

    public void Visit(Pistole weapon, float damage, RaycastHit hit)
    {
        HitHandlingEnemy(damage, hit);

    }
    public void Visit(ShotGun weapon, float damage, RaycastHit hit)
    {
        HitHandlingEnemy(damage, hit);

    }

    public void Visit(MachineGun weapon, float damage, RaycastHit hit)
    {
        if (damage > 0)
        {
            HitHandlingEnemy(damage, hit);
        }
    }


    private void HitHandlingEnemy(float damage, RaycastHit hit)
    {
        _rigidbody.useGravity = true;
        AddForceToItem(damage);
        this.InvokeTime(DestroyEnemy, _destroyTime);
        SpawnBlood(_hitBlodPreset, hit);
    }

    private void AddForceToItem(float damage)
    {
        var force = _camera.forward;
        _rigidbody.AddForce(force * damage, ForceMode.Impulse);
    }

    private void DestroyEnemy()
    {
        gameObject.SetActive(false);
    }
    private GameObject SpawnBlood(GameObject decal, RaycastHit hit)
    {
        Quaternion _rotationBlodPrefab = Quaternion.LookRotation(_camera.forward.normalized);
        return Instantiate(_hitBlodPreset, hit.point, _rotationBlodPrefab);
    }
}