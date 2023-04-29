﻿using System;
using UnityEngine;

namespace DefaultNamespace
{
    public class EnemyController : MonoBehaviour
    {
        [SerializeField] private int damage = 10; // amount of damage dealt to player
        [SerializeField] private GameObject hitEffectPrefab; // particle effect played when hit
        private HeroController _heroController;

        private void Start()
        {
            _heroController = FindObjectOfType<HeroController>();
        }

        private void Update()
        {
        }

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.CompareTag("MainHero"))
            {
                HeroController playerHealth = collision.GetComponentInParent<HeroController>();
                
                if (playerHealth != null)
                {
                    _heroController.CurrentHealth -= damage;
                    Debug.Log("hahah");
                }
            }
        }
    }
}