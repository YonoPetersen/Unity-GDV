using UnityEngine;

public class Enemy : MonoBehaviour
{
    public string enemyType = "Goblin";
    public int health = 50;
    public int damage = 10;

    public void TakeDamage(int amount)
    {
        health -= amount;
        Debug.Log(enemyType + " took " + amount + " damage! Health left: " + health);

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log(enemyType + " died!");
        Destroy(gameObject); 
    }
}