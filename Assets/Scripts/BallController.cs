using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class BallController : MonoBehaviour
{
    NavMeshAgent myAgent;
    Transform playerTran;
    public float startTime;

    // Start is called before the first frame update
    void Start()
    {
        myAgent = GetComponent<NavMeshAgent>();
        playerTran = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        startTime -= Time.deltaTime;
        if(startTime < 0) {
            myAgent.SetDestination(playerTran.position);
        }
    }
}
