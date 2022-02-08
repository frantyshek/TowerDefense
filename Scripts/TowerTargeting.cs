using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerTargeting : MonoBehaviour
{

    [SerializeField] Transform weapon;
    [SerializeField] Transform target;

    void Start()
    {
        target = FindObjectOfType<EnemyMovement>().transform;
        weapon = gameObject.transform.GetChild(1);
    }

    void Update()
    {
        AimWeapon();
    }

    void AimWeapon()
    {
        weapon.LookAt(target);
    }
}
