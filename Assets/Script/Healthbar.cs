using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Healthbar : MonoBehaviour
{
    public int health = 100;
    public int maxHealth = 100;
    public TextMeshProUGUI textHealth;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            Debug.Log("H key detected");
            TakeDamage(20);
            DisplayHealth();
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            Debug.Log("L key detected");
            TakeHealing(20);
            DisplayHealth();
        }
    }

    public void DisplayHealth()
    {
        textHealth.text = health.ToString();
    }

    public void TakeDamage(int incomingDamage)
    {
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

    public void TakeHealing(int incomingHealing)
    {
        health += incomingHealing;
        Debug.Log("Took " + incomingHealing + " healing! Health: " + health);

        if (health <= 0)
        {
            Die();
        }
        else if (health == 100)
        {
            Debug.Log("Full health!");
        }
    }

    void Die()
    {
        Debug.Log("Player died!");
        Destroy(gameObject);
    }
}