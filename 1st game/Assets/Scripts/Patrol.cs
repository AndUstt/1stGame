using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(EnemyVision))]
public class Patrol : MonoBehaviour
{
    [SerializeField] Transform[] PatrolPoints;
    
    private NavMeshAgent _agent;
    private int _pointIndex;
    private EnemyVision _enemyVision;
    private bool _isHunting;
    void Awake()
    {
        _agent = GetComponent<NavMeshAgent>();
        _enemyVision = GetComponent<EnemyVision>();
    }

    void Start()
    {
        _enemyVision.PlayerInVision += OnPlayerInVision;
        _enemyVision.PlayerLost += SetPatrolPoint;
    }


    void Update()
    {
     if (!_agent.pathPending && !_isHunting && _agent.remainingDistance <= 0f)
        {
            SetPatrolPoint();  
        }  
    }
    void SetPatrolPoint()
    {
        var dest = PatrolPoints[_pointIndex % PatrolPoints.Length].position;
        _agent.destination = dest;

        _isHunting = false;
        _pointIndex++;
    }
    
    void OnPlayerInVision(Vector3 pos)
    {
        _agent.destination = pos;
        _isHunting = true;
    }
}
