using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgentManager : MonoBehaviour
{
    GameObject[] agents;//classe GameObject Agents
    
    void Start()
    {
        agents = GameObject.FindGameObjectsWithTag("ai");//Procura GameObject com a tag "ai"
    }
    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))//pega informa��o do Raycast e vai at� o destino
                                      
        {
            RaycastHit hit;//guarda informa��es do objeto
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {
                foreach (GameObject a in agents)
                    a.GetComponent<AIControl>().agent.SetDestination(hit.point);
            }
        }
    }
}
