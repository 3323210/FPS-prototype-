using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UilDisplayShotGunProjectile : MonoBehaviour
{
    [SerializeField] private ProjctlShotGun _projctlShotGun;
    [SerializeField] private Text _textCountBullets ;
    private void OnEnable()
    {
        _projctlShotGun.CountShotGunProjectile += UpdateNumberOfBullets;
    }
    private void OnDisable()
    {
        _projctlShotGun.CountShotGunProjectile -= UpdateNumberOfBullets;
    }
    private void Update()
    {
    }
    private void UpdateNumberOfBullets(int bullets)
    {
        _textCountBullets.text = bullets.ToString();
    }
}
