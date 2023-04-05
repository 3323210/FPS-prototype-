using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeAtakAnimation : MonoBehaviour
{
    private Animator _animationAtak;
    private void Awake()
    {
        _animationAtak = gameObject.GetComponent<Animator>();
    }
    
    private void OnEnable()
    {
        PlayerAtakController.OnAtakWeapon += StartAtak;
    }
    private void OnDisable()
    {
        PlayerAtakController.OnAtakWeapon -= StartAtak;

    }
    public void StartAtak()
    {
        _animationAtak.SetTrigger("KnifeAtak");
         
    }

}
