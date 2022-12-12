using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack : MonoBehaviour
{
    private void OnTriggerStay(Collider collision)
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (collision.CompareTag("Enemy"))
            {
                GameManager.EnemyHealth -= 50;
            }
        }
    }
}
