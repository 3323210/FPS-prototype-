using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundShotGunWeapon : MonoBehaviour
{
    [SerializeField] private AudioClip _soundSinleShot;
    [SerializeField] private AudioClip _soundMisfireShot;
    [SerializeField] private float _timeReject = 0.5f;

    private AudioSource _shotShotGunAudio;

    private void OnEnable()
    {
        ProjctlShotGun.RealSoundSingleShotWeapon += ShotSound;
        ProjctlShotGun.FalseSingleShotWeapon += MistfireSound;
    }
    private void OnDisable()
    {
        ProjctlShotGun.RealSoundSingleShotWeapon -= ShotSound;
        ProjctlShotGun.FalseSingleShotWeapon -= MistfireSound;
    }
    private void Awake()
    {
        _shotShotGunAudio = GetComponent<AudioSource>();

    }

    private void ShotSound()
    {
        _shotShotGunAudio.PlayOneShot(_soundSinleShot);
        this.InvokeTime(MistfireSound, _timeReject);
    }

    private void MistfireSound()
    {
        _shotShotGunAudio.PlayOneShot(_soundMisfireShot);
    }

}

