using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<GameObject> bloodVials = new List<GameObject>();
    public int vialAmount = 0;

    public GameObject hud;
    public bool hudActive;

    public HealthBar healthBar;
    public BloodVial bloodVial;

    public int maxHealth = 10;
    public int currentHealth;

    public int maxBlood = 10;
    public int currentBlood;

    private void Start()
    {
        hudActive = false;
        hud.SetActive(false);

        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Tab) && !hudActive)
        {
            hud.SetActive(true);
            hudActive = true;
        }

        else if (Input.GetKeyDown(KeyCode.Tab) && hudActive)
        {
            hud.SetActive(false);
            hudActive = false;
        }

        if (Input.GetKeyDown(KeyCode.B) && hudActive)
        {
            TakeDamage(1);
            FillVial();
        }

        if(currentHealth <= 0)
        {
            Debug.Log("DEAD");

        }
    }

    
    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("Vial"))
        {
            //FillVial();
            Destroy(other.gameObject);
            vialAmount += 1;
        }
    }
    

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }

    void FillVial()
    {
        currentBlood += 1;

        bloodVial.SetBlood(currentBlood);
    }

    public void DepleateVial()
    {
        vialAmount -= 1;
    }
}
