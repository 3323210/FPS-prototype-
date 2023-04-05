using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UilDisplayPistoleProjectile : MonoBehaviour
{
    [SerializeField] private ProjctlPistole _projctlSingleShotWeapon;
    [SerializeField] private Text _textCountBullets ;
    private void OnEnable()
    {
        _projctlSingleShotWeapon.CountPistoleProjectile += UpdateNumberOfBullets;
    }
    private void OnDisable()
    {
        _projctlSingleShotWeapon.CountPistoleProjectile -= UpdateNumberOfBullets;
    }
    private void Update()
    {
    }
    private void UpdateNumberOfBullets(int bullets)
    {
        _textCountBullets.text = bullets.ToString();
    }
}
