using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxhealth = 100;
    public int currentHealth;

    public HealthBar healthBar;
    void Start()
    {
        currentHealth = maxhealth;
        healthBar.SetMaxHealth(maxhealth);
    }


    void Update()
    {
        //test damage
        // if (Input.GetKeyDown(KeyCode.H))
        // {
        //     TakeDamage(20);
        // }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }
}
