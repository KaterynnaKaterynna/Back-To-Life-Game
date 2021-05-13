using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonCharacterMovement : MonoBehaviour
{
    [SerializeField]
    private int _health = 1;
    public float _speed;
    Vector3 playerMovement;
    Animator _animator;

    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    public void Hurt(int damage)
    {
        _health -= damage;
        if (_health <= 0) 
            Die();
    }

    private void Die()
    {
        _animator.SetBool("IsDead", true);
    }

    private void FixedUpdate()
    {
        PlayerMovement();
        Animation();
    }

    private void PlayerMovement()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        playerMovement = new Vector3(horizontal, 0f, vertical) * _speed * Time.deltaTime;
        transform.Translate(playerMovement, Space.Self);

    }

    





    private void Animation()
    {
        if (Input.GetKey("w") || Input.GetKey("a") || Input.GetKey("d"))
        {
            _animator.SetBool("IsWalking", true);
        }
        else
        {
            _animator.SetBool("IsWalking", false);
        }
    }




}
