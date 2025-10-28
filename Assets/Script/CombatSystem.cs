using UnityEngine;

public class CombatSystem : MonoBehaviour
{
    public int health = 100;
    public int maxHealth = 100;
    public bool isBlocking = false;

    void Update()
    {
        // Blocking
        if (Input.GetKey(KeyCode.G))
        {
            isBlocking = true;
            Debug.Log("Blocking!");
        }
        else
        {
            isBlocking = false;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Enemy enemy = other.GetComponent<Enemy>();
            if (enemy != null)
            {
                TakeDamage(enemy.damage);
            }
        }
    }

    public void TakeDamage(int incomingDamage)
    {
        if (isBlocking)
        {
            incomingDamage /= 2; // halve damage
            Debug.Log("Blocked! Damage reduced to " + incomingDamage);
        }

        health -= incomingDamage;
        Debug.Log("Took " + incomingDamage + " damage! Health: " + health);

        if (health <= 0)
        {
            Die();
        }
        else if (health < 20)
        {
            Debug.Log("WARNING: Low health!");
        }
    }

    void Die()
    {
        Debug.Log("Player died!");
        Destroy(gameObject);
    }
}