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
    public bool destroyed;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }
    void Update()
    {
        agent.SetDestination(pos[posNumb].transform.position);
        dist = Vector3.Distance(pos[posNumb].transform.position, transform.position);
        if (dist<1f)
        {
            posNumb++;
        }
        if (posNumb >= pos.Count)
        {
            if (destroyed)
            {
                Destroy(gameObject);
            }
            posNumb = 0;
        }
    }
}
