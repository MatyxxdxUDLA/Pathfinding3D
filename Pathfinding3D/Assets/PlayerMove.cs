using UnityEngine;
using UnityEngine.AI;


public class PlayerMove : MonoBehaviour
{
    public NavMeshAgent agente;
    public Camera camara;

    void Start()
    {
        if(agente == null) agente = GetComponent<NavMeshAgent>();
        if(camara == null) camara = Camera.main;
    }

    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            MoverJugador();
        }
    }

    void MoverJugador()
    {
        Ray ray = camara.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit))
        {
            agente.SetDestination(hit.point);
        }
    }
}
