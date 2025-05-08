using NUnit.Framework;
using UnityEngine;
using UnityEngine.AI;
using System.Collections.Generic;
public class Umbrella : MonoBehaviour
{
    NavMeshAgent agent;
    public List<GameObject> pos;
    private int posNumb = 0;
    float dist = 0;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        dist = Vector3.Distance(pos[posNumb].transform.position, transform.position);
        if (dist<1f)
        {
            posNumb++;
        }
        if (posNumb >= pos.Count)
        {
            posNumb = 0;
        }
        agent.SetDestination(pos[posNumb].transform.position);
    }
}
