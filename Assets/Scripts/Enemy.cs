using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IDamage
{
    [SerializeField] private float health;

    public void hit(float damageAmount)
    {
        health -= damageAmount;
        print(health);
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void TakeDamage(float DamageAmount)
    {
        hit(DamageAmount);
    }

    public void uppy(float distance)
    {
        this.transform.Translate(Vector3.up * Time.deltaTime * 100, Space.World);
    }
    public void rotatE()
    {
        this.transform.Rotate(new Vector3(90f,0f,0f), Space.Self);
    }
}
