using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

    public Transform[] m_player;
    public float m_dampTime = 0.2f;
    private Vector3 m_velocity;
    private int m_currentPlayer = 0;


    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    private void FixedUpdate()
    {
        if(Input.GetKeyDown("space")) //TODO: swap the if for actions points = 0 or player or enemy pass his turn 
        {
            m_currentPlayer = m_currentPlayer + 1 >= m_player.Length ? 0 : m_currentPlayer + 1;
        }

       transform.position = Vector3.SmoothDamp(transform.position, m_player[m_currentPlayer].position, ref m_velocity, m_dampTime);
        

    }
}
