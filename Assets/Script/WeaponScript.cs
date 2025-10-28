using UnityEngine;

public class WeaponScript : MonoBehaviour
{
    public string currentWeapon = "Sword";
    public int damage;
    public float attackSpeed;

    private float nextAttackTime = 0f;

    void Start()
    {
        SetWeaponStats();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (Time.time >= nextAttackTime)
            {
                Attack();
                nextAttackTime = Time.time + 1f / attackSpeed;
            }
        }
        if (Input.GetKeyDown(KeyCode.Alpha1)) EquipWeapon("Sword");
        else if (Input.GetKeyDown(KeyCode.Alpha2)) EquipWeapon("Bow");
        else if (Input.GetKeyDown(KeyCode.Alpha3)) EquipWeapon("Staff");
        else if (Input.GetKeyDown(KeyCode.Alpha4)) EquipWeapon("Dagger");
    }

    void EquipWeapon(string weaponName)
    {
        currentWeapon = weaponName;
        SetWeaponStats();
        Debug.Log("Equipped: " + currentWeapon);
    }

    void SetWeaponStats()
    {
        switch (currentWeapon)
        {
            case "Sword":
                damage = 25;
                attackSpeed = 1.0f;
                break;
            case "Bow":
                damage = 20;
                attackSpeed = 1.5f;
                break;
            case "Staff":
                damage = 35;
                attackSpeed = 0.7f;
                break;
            case "Dagger":
                damage = 15;
                attackSpeed = 2.0f;
                break;
            default:
                damage = 10;
                attackSpeed = 1.0f;
                break;
        }
        Debug.Log(currentWeapon + " equipped! Damage: " + damage + ", Speed: " + attackSpeed);
    }

    void Attack()
    {
        Debug.Log("Swinging " + currentWeapon);

        Collider[] hits = Physics.OverlapSphere(transform.position + transform.forward * 1f, 1.5f);
        foreach (Collider hit in hits)
        {
            if (hit.CompareTag("Enemy"))
            {
                Enemy enemy = hit.GetComponent<Enemy>();
                if (enemy != null)
                {
                    enemy.TakeDamage(damage);
                    Debug.Log("Hit " + enemy.enemyType + " for " + damage);
                }
            }
        }
    }
}