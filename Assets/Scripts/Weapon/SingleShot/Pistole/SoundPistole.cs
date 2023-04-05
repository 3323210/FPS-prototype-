using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundPistole : MonoBehaviour
{
    [SerializeField] private AudioClip _soundShotPistole;
    [SerializeField] private AudioClip _soundNotShotPistole;

    private AudioSource _shotPistolAudio;
    private void OnEnable()
    {
        ProjctlPistole.RealSoundSingleShotWeapon += ShotSound;
        ProjctlPistole.FalseSingleShotWeapon += MistfireSound;
    }
    private void OnDisable()
    {
        ProjctlPistole.RealSoundSingleShotWeapon -= ShotSound;
        ProjctlPistole.FalseSingleShotWeapon -= MistfireSound;
    }

    private void Awake()
    {
        _shotPistolAudio = GetComponent<AudioSource>();
    }
    private void MistfireSound()
    {
        _shotPistolAudio.PlayOneShot(_soundNotShotPistole);
    }

    private void ShotSound()
    {
        _shotPistolAudio.PlayOneShot(_soundShotPistole);
    }
}
