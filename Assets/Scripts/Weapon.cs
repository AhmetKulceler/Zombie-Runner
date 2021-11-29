using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] Camera FPCamera;
    [SerializeField] float weaponRange = 100f;
    [SerializeField] float weaponDamage = 20f;

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(FPCamera.transform.position, FPCamera.transform.forward, out hit, weaponRange))
        {
            Debug.Log(hit.transform.name);
            // TODO: add some hit effect for visual players

            EnemyHealth enemyTarget = hit.transform.GetComponent<EnemyHealth>();

            if (enemyTarget == null) return;
            enemyTarget.TakeDamage(weaponDamage);
        }
        else return;
    }
}
