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
        if (Input.GetMouseButtonDown(0))//pega informação do Raycast e vai até o destino
                                      
        {
            RaycastHit hit;//guarda informações do objeto
            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            {
                foreach (GameObject a in agents)
                    a.GetComponent<AIControl>().agent.SetDestination(hit.point);
            }
        }
    }
}
