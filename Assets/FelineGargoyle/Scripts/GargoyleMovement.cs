using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GargoyleMovement : MonoBehaviour
{
    [SerializeField]
    private Transform _target;

    [SerializeField]
    private float _speed = 1f;

    void Update()
    {
        var relativePosition = _target.position - transform.position;
        var rotation = Quaternion.LookRotation(relativePosition);
        transform.rotation = rotation;
    }
}
