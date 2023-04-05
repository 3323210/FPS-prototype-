using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IWeaponVisitor 
{
    void Visit(Knife weapon, float damage);
    void Visit(Pistole weapon, float damage,RaycastHit hit);
    void Visit(ShotGun weapon, float damage, RaycastHit hit);
    void Visit(MachineGun weapon, float damage, RaycastHit hit);

}

