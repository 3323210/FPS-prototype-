using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistoleAtakAnimationn : MonoBehaviour
{
    private Animator _animationAtakPistole;
    private void Awake()
    {
        _animationAtakPistole = gameObject.GetComponent<Animator>();
    }

    private void OnEnable()
    {
        ProjctlPistole.RealSoundSingleShotWeapon += StartAtak;
    }
    private void OnDisable()
    {
        ProjctlPistole.RealSoundSingleShotWeapon -= StartAtak;

    }
    public void StartAtak()
    {
        _animationAtakPistole.SetTrigger("AtakPistole");
    }

}
