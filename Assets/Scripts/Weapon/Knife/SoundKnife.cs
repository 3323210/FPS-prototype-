using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundKnife : MonoBehaviour
{
    [SerializeField]private AudioClip _soundAtak;
    [SerializeField] private AudioClip _soundFaleAtak;
    [SerializeField] private float _timeSekondSound;

    private AudioSource _KnifeAudio;

    private void OnEnable()
    {
        Knife.KnifefAtakTrue += TrueAtakKnifeSound;
        Knife.KnifeAtakFalse += FaileAtakKnifeSound;
    }
    private void OnDisable()
    {
        Knife.KnifefAtakTrue -= TrueAtakKnifeSound;
        Knife.KnifeAtakFalse -= FaileAtakKnifeSound;
    }

    private void Awake()
    {
        _KnifeAudio = GetComponent<AudioSource>();

    }
    private void TrueAtakKnifeSound()
    {
        SoundAtak();
    }
    private void FaileAtakKnifeSound()
    {

        SoundFaileAtak();
        this.InvokeTime(SoundFaileAtak, _timeSekondSound);
    }
    private void SoundAtak()
    {
        _KnifeAudio.PlayOneShot(_soundAtak);

    }
    private void SoundFaileAtak()
    {
        _KnifeAudio.PlayOneShot(_soundFaleAtak);
        
    }
}
