using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace monkeyMath
{
    public class Bullet : MonoBehaviour
    {
        public float speed;
        public Rigidbody2D rb;
        public int damage = 10;

        // Start is called before the first frame update
        void FixedUpdate()
        {
            rb.velocity = transform.right * Time.deltaTime * speed;
            Debug.Log("Go Right Bullet");
        }

        void OnTriggerEnter2D(Collider2D hitInfo)
        {
            Enemy enemy = hitInfo.GetComponent<Enemy>();

            if(enemy != null)
            {
                enemy.TakeDamage(damage);
            }
            Destroy(gameObject);
        }
    }
}
