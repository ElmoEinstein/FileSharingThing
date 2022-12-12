using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : MonoBehaviour
{
    public Animator animator;
    [SerializeField] GameObject food;

    private void Update()
    {
        TakeDamage(GameManager.EnemyHealth);

    }


    public void TakeDamage(int damageAmount)
    {
        if(damageAmount <= 0)
        {

            Instantiate(food, transform.position, Quaternion.identity);
            
            Destroy(gameObject);
        }
    }
}
