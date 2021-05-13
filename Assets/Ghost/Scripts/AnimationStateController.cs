using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController : MonoBehaviour
{
    Animator _animator;



    private void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    
    private void Update()
    {
        
    }
}
