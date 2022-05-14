using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class AIControl : MonoBehaviour
{
    public NavMeshAgent agent;//classe que pega o NavMeshAgent
    
    void Start()
    {
        agent = this.GetComponent<NavMeshAgent>();//Guarda a referencia do componente que está no objeto. 
    }
}