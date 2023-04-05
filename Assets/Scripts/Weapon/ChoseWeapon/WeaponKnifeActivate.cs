using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponKnifeActivate : State
{
    private Knife _weaponKnife;
    public WeaponKnifeActivate(Knife knife)
    {
        _weaponKnife = knife;
    }

    public override void Enter()
    {
        base.Enter();
        _weaponKnife.gameObject.SetActive(true);
    }
    public override void Exit()
    {
        base.Exit();
        _weaponKnife.gameObject.SetActive(false);
    }
}
