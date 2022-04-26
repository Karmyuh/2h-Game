using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    MoveController _moverController;
    [SerializeField] Transform _playerTransform;
    [SerializeField] Rigidbody2D _playerRigidBody2D;
    [SerializeField] SpriteRenderer _playerSpriteRenderer;


    [Range (5,10)][SerializeField] float _playerSpeed;
    [Range (250,350)][SerializeField] float _playerJumpForce;
    [SerializeField] bool _isHorizontalActive,_isJumpActive,_isFlipActive;
    bool _isSpaceControl;
    private void Awake()
    {
        _moverController = new MoveController();
    }
    private void FixedUpdate()
    {
        Walk();
        Jump();
        Flip();
    }
    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            _isSpaceControl = true;
        }
    }
    void Walk()
    {
        _moverController.Horizontal(_playerTransform, _playerSpeed, _isHorizontalActive);
    }

    void Jump()
    {
        if (_isSpaceControl)
        {
            _moverController.Jump(_playerRigidBody2D, _playerJumpForce, _isJumpActive);
        }
        _isSpaceControl = false;
        
    }
    void Flip()
    {
        _moverController.Flip(_playerSpriteRenderer, _isFlipActive);
    }
    void Climb()
    {

    }
}
