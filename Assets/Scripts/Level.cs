using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    [SerializeField] private Score _score;

    private void OnEnable()
    {

    }
    private void OnDisable()
    {
    }

    private void Start()
    {
        Restart();
    }

    public void Restart()
    {
        PreparePlayer();
        PrepareEnemyes();
    }

    private void PreparePlayer()
    {
       
    }

    private void PrepareEnemyes()
    {
      
    }

    private void OnPlayerDied()
    {
        Restart();
    }

    private void OnEnemyDied()
    {
        
    }

    private void FinishGame()
    {
       
    }
    private void OnEnemyEnteredLosingZone()
    {
       
    }

}
