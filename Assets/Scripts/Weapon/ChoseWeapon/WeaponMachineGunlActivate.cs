using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponMachineGunlActivate : State
{

    private MachineGun _machineGun;

    public WeaponMachineGunlActivate(MachineGun machineGun)
    {
        _machineGun = machineGun;
    }
   
    public override void Enter()
    {
        base.Enter();
        _machineGun.gameObject.SetActive(true);
    }
    public override void Update()
    {
        base.Update();

    }
    public override void Exit()
    {
        base.Exit();
        _machineGun.gameObject.SetActive(false);
    }
}
