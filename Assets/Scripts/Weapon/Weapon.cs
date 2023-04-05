using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    [SerializeField] protected float _damageWeapon;
    [SerializeField] private Transform _shotPoint;
    [SerializeField] private Transform _pointer;
    protected RaycastHit hit;

    private void Update()
    {
        Ray ray = new Ray(transform.position, transform.up);
        Debug.DrawRay(transform.position, transform.up * 20, Color.yellow);

        if (Physics.Raycast(ray, out hit))
        {
            _pointer.position = hit.point;
        }
    }
   
    protected abstract void Accept(IWeaponVisitor weaponVisitor, float damageWeapon, RaycastHit hit);
}
