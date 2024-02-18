﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyLocomotion : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;
    private Animator animator;

    private int speedParam = Animator.StringToHash("Speed");

    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (navMeshAgent.hasPath)
        {
            animator.SetFloat(speedParam, navMeshAgent.velocity.magnitude);
        }
        else
        {
            animator.SetFloat(speedParam, 0);
        }
    }
}
