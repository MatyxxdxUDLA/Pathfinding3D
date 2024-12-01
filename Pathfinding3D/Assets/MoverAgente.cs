using UnityEngine;
using UnityEngine.AI;


public class MoverAgente : MonoBehaviour
{
    public NavMeshAgent agente;
    public Transform destino;

    void Start()
    {
        if(agente == null)
        {
            agente = GetComponent<NavMeshAgent>();
        }
    }

    void Update()
    {
        if(destino != null)
        {
            agente.SetDestination(destino.position);
        }
    }
}
