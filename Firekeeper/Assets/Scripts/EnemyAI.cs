﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    public GameObject player;
    public List<GameObject> enemies;
    public List<NavMeshAgent> agents;
    public List<Enemy> enemyScripts;
    public float speed = 0.3f;
    
    public bool initialised = false;

    void Start()
    {
        
    }

    void Update()
    {
        
        for(int loop = 0; loop < agents.Count; loop++)
        {
            NavMeshAgent agent = agents[loop];
            if (agent != null)
            {
                if (enemyScripts[loop].alive)
                {
                    // agent.velocity = (player.transform.position - agent.transform.position) * speed;
                    agent.SetDestination(player.transform.position);
                }
            }
        }

    }

    public void Exterminate()
    {
        foreach( Enemy enemy in enemyScripts )
        {
            if (enemy != null)
            {
                if (enemy.alive)
                {
                    enemy.StartDeath();
                }
            }
        }
    }
}
