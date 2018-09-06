using UnityEngine.AI;
using UnityEngine;

public class Player : PlayerController {

    NavMeshAgent agent;

    GameManager m_gameManager; //
    
        void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        m_gameManager = GameObject.Find("ObjectGameManager").GetComponent<GameManager>();
        m_level = 1;
    }

    void Update()
    { 
        if(m_gameManager.m_fightMode)//if fightmode then player with high iniciative can act
        {
            
        }
        else
        {
            if (Input.GetMouseButtonDown(0)) //TODO: if fightmode = false then all group can move
            {
                RaycastHit hit;

                if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
                {
                    agent.destination = hit.point;
                }
            }
        }
        

        
    }
}
