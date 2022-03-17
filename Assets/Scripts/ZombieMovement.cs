using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class ZombieMovement : MonoBehaviour
{
    NavMeshAgent zombie;
    Transform player;
    // Start is called before the first frame update
    void Start()
    {
        zombie = GetComponent<NavMeshAgent>();
        player = GameObject.FindGameObjectWithTag("Player").transform; 
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        zombie.SetDestination(player.position);
    }
}
