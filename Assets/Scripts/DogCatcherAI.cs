using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class DogCatcherAI : MonoBehaviour

{
    private NavMeshAgent agent;
    public GameObject player;
    public Vector3 DogCatcherSpawn;

    void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
        DogCatcherSpawn = this.transform.position;
    }

    void Update()
    {
        agent.SetDestination(player.transform.position);
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerController>().Respawn();
            gameObject.transform.position = DogCatcherSpawn;
            gameObject.SetActive(false);
        
        }
    }
}