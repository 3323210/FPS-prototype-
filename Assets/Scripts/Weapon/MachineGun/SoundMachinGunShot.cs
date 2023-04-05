using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundMachinGunShot : MonoBehaviour
{
    [SerializeField] private AudioClip _soundShotMachinShotGun;
    [SerializeField] private AudioClip _soundNotShotMachinGun;

    private AudioSource _shotMachinGunAudio;

    private void OnEnable()
    {
        ProjctlMachineGun.OnShotBoletTrue += ShotSound;
        ProjctlMachineGun.OnShotBoletFalse += MistfireSound;
    }
    private void OnDisable()
    {
        ProjctlMachineGun.OnShotBoletTrue -= ShotSound;
        ProjctlMachineGun.OnShotBoletFalse -= MistfireSound;
    }

    private void Awake()
    {
        _shotMachinGunAudio = GetComponent<AudioSource>();

    }
    private void ShotSound()
    {
        _shotMachinGunAudio.PlayOneShot(_soundShotMachinShotGun);

    }
    private void MistfireSound()
    {
        _shotMachinGunAudio.PlayOneShot(_soundNotShotMachinGun);
    }

}
