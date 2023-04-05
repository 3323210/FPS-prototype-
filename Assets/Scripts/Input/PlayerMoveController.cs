using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMoveController : MonoBehaviour
{
    private Controls _inputs;
    private Vector3 _moveDirection;
    private Vector2 _side;

    [SerializeField] private float _speedMove = 5f;
    [SerializeField] private float _speedRotate = 0.5f;

    private void Awake()
    {
        _inputs = new Controls();
    }
    private void OnEnable()
    {
        _inputs.Enable();
    }
    private void OnDisable()
    {
        _inputs.Disable();
    }
    private void ValueControls()
    {
        _side = _inputs.Player.MoveWASD.ReadValue<Vector2>();
        
    }
   
    private void FixedUpdate()
    {
        ValueControls();
        Move();
    }
    
    private void Move()
    {
        _moveDirection = new Vector3(_side.x, 0, _side.y);
        transform.position+=transform.TransformDirection(_moveDirection * _speedMove * Time.fixedDeltaTime);
        transform.Rotate(0, _side.x*_speedRotate, 0);
    }

}
