using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlowerMine : MonoBehaviour
{
    [SerializeField]
    private int _damage = 1;
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<CapsuleCollider>() != null)
        {
            var target = other.GetComponent<ThirdPersonCharacterMovement>();
            target.Hurt(_damage);
            Destroy(gameObject);
        }
    }
}
