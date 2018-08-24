using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

    public Transform[] m_player;
    public float m_dampTime = 0.2f;
    private Vector3 m_velocity;
    private int m_currentPlayer = 0;

    public float scrollSpeed = 50;
    public float topBarrier = 0.9f;
    public float botBarrier = 0.01f;
    public float rightBarrier = 0.1f;
    public float leftBarrier = 0.9f;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    /*private void FixedUpdate()
    {
        /*
        if(Input.GetKeyDown("space")) //TODO: swap the if for actions points = 0 or player or enemy pass his turn 
        {
            m_currentPlayer = m_currentPlayer + 1 >= m_player.Length ? 0 : m_currentPlayer + 1;
        }

       transform.position = Vector3.SmoothDamp(transform.position, m_player[m_currentPlayer].position, ref m_velocity, m_dampTime);
        

        
    }
    */
    void Updated()
    {
        //It would must move the position camera depeding where is our mouse in the screen
        if (Input.mousePosition.y >= Screen.height * topBarrier)
        {
            transform.Translate(Vector3.up * Time.deltaTime * scrollSpeed, Space.World);
        }
        if (Input.mousePosition.y <= Screen.height * botBarrier)
        {
            transform.Translate(Vector3.down * Time.deltaTime * scrollSpeed, Space.World);
        }
        if (Input.mousePosition.x >= Screen.width * rightBarrier)
        {
            transform.Translate(Vector3.right * Time.deltaTime * scrollSpeed, Space.World);
        }
        if (Input.mousePosition.x <= Screen.width * leftBarrier)
        {
            transform.Translate(Vector3.left * Time.deltaTime * scrollSpeed, Space.World);
        }
    }
}
