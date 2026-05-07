using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int coins;
    
    public GameObject fireballPrefab;
    public Transform attackPoint;
    private int health = 10;

    public void TakeDamage(int damage)
    {
        health -= damage;
        print("ХП:" + health);
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab,attackPoint.position, attackPoint.rotation);
        }

    }
    public void CollectCoins()
    {
        coins += 1;
        print("Монеты:" + coins);
    }
}
