using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int health = 1;

    private int MAX_HEALTH = 10;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            // Damage(10);
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            // Heal(10);
        }
    }

    public void Damage(int amount)
    {
        if (amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("Cannot have negative Damage");
        }

        this.health -= amount;

        if (health <= 0)
        {
            Die();
        }
    }

    void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider.otherCollider.gameObject.tag == "man")
        {
            Debug.Log("yoyo");
        }
    }
    /*public void Heal(int amount)
    {
        if (amount < 0)
        {
            throw new System.ArgumentOutOfRangeException("Cannot have negative healing");
        }

        bool wouldBeOverMaxHealth = health + amount > MAX_HEALTH;

        if (wouldBeOverMaxHealth)
        {
            this.health = MAX_HEALTH;
        }
        else
        {
            this.health += amount;
        }
    }*/

    private void Die()
    {
        Debug.Log("I am Dead!");
        SoundManager.instance.Play("ldoyr");
        gameObject.GetComponent<ObjectMovementPoints>().enabled = false;
        gameObject.GetComponent<DieBird>().enabled = true;
        //Destroy(gameObject);
    }
}