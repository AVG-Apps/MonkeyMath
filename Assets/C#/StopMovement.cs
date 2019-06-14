using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace monkeyMath
{

    public class StopMovement : MonoBehaviour
    {
        private Player player;
        public GameObject bigBossTrigger;
        private Excercise exercise;
        private BigBoss bigBoss;

        void Start()
        {
            player = FindObjectOfType<Player>();
            exercise = FindObjectOfType<Excercise>();
            bigBoss = FindObjectOfType<BigBoss>();

        }


        private void OnTriggerEnter2D(Collider2D playerCollider)
        {
            if (playerCollider.tag == "Player")
            {
                //exercise.bigboss = true;
                player.move = false;
                Destroy(bigBossTrigger);
                bigBoss.startGame();
            }
        }
    }
}
