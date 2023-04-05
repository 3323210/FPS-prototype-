using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UilDisplayMashineGunProjectile : MonoBehaviour
{
    [SerializeField] private ProjctlMachineGun _projctlMashineGun;
    [SerializeField] private Text _textCountBullets ;
    private void OnEnable()
    {
        _projctlMashineGun.CountMashineGunProjectile += UpdateNumberOfBullets;
    }
    private void OnDisable()
    {
        _projctlMashineGun.CountMashineGunProjectile -= UpdateNumberOfBullets;
    }
    private void Update()
    {
    }
    private void UpdateNumberOfBullets(int bullets)
    {
        _textCountBullets.text = bullets.ToString();
    }
}
