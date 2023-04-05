using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChoiseActiweWeapon : MonoBehaviour
{
    private StateMashina _SM;

    [SerializeField] private Knife _weaponKnife;
    [SerializeField] private Pistole _weaponPistole;
    [SerializeField] private ShotGun _weaponShotGun;
    [SerializeField] private MachineGun _weaponMachineGun;

    private void OnEnable()
    {
        PlayerChoiceWeapon.choiceKnife += KnifeAktivate;
        PlayerChoiceWeapon.choicePistole += PistoleAktivate;
        PlayerChoiceWeapon.choiceShotGun += ShotGunAktivate;
        PlayerChoiceWeapon.choiceMachineGun += MachineGunAktivate;
    }
    private void OnDisable()
    {
        PlayerChoiceWeapon.choiceKnife -= KnifeAktivate;
        PlayerChoiceWeapon.choicePistole -= PistoleAktivate;
        PlayerChoiceWeapon.choiceShotGun -= ShotGunAktivate;
        PlayerChoiceWeapon.choiceMachineGun -= MachineGunAktivate;
    }

    private void Start()
    {
        _SM = new StateMashina();
        _SM.Initialize(new WeaponPistolActivate(_weaponPistole));
    }
    private void Update()
    {
        _SM.CurrenState.Update();

    }
    void KnifeAktivate()
    {
        _SM.ChangeState(new WeaponKnifeActivate(_weaponKnife));
    }

    void PistoleAktivate()
    {
        _SM.ChangeState(new WeaponPistolActivate(_weaponPistole));
    }
    void ShotGunAktivate()
    {
        _SM.ChangeState(new WeaponShotGunlActivate(_weaponShotGun));
    }
    void MachineGunAktivate()
    {
        _SM.ChangeState(new WeaponMachineGunlActivate(_weaponMachineGun));
    }
}
