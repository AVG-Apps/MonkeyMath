using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace monkeyMath
{
    public class BigBoss : MonoBehaviour
    {
        public int health = 100;
        public GameObject deathEffect;

        private LevelManager levelManager;

        private void Start()
        {
            levelManager = FindObjectOfType<LevelManager>();
        }


        public void TakeDamage(int damage)
        {
            health -= damage;

            if(health <= 0)
            {
                Die();
            }
        }

        void Die()
        {
            Instantiate(deathEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }


        public void startGame()
        {
            //levelManager.exercises;
        }
    }
}
