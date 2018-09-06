using UnityEngine;

public class CameraControl : MonoBehaviour {

    public Transform[] m_player;
    public float m_dampTime = 0.2f;
    public float m_ZoomSpeed = 6.0f;
    public float m_RotationSeed = 1.0f;
    public float m_ScrollSpeed = 6.0f;

    public float topBarrier = 0.9f;
    public float botBarrier = 0.01f;
    public float rightBarrier = 0.1f;
    public float leftBarrier = 0.9f;

    private int m_currentPlayer = 0;
    private Vector3 m_velocity;
    private Camera m_Camera;

    GameManager m_gameManager;

    private void SwitchPlayers()
    {
        transform.position = Vector3.SmoothDamp(transform.position, m_player[m_currentPlayer].position, ref m_velocity, m_dampTime);
    }

    // Use this for initialization
    void Start () {
        m_Camera = GetComponentInChildren<Camera>();
        m_gameManager = GameObject.Find("ObjectGameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if (m_gameManager.m_fightMode) //at the moment, always it's true
        {
            if(m_gameManager.m_freeCamera == false) //initialized true in GameManager
            {
                SwitchPlayers();
                if (m_velocity == Vector3.zero)
                {
                    m_gameManager.m_freeCamera = true;
                }
            }
        }
        if (m_gameManager.m_freeCamera)
        {
            UpdateMovementInput();
            UpdateZoomInput();
            UpdateRotation();

            if (Input.GetKeyDown("space")) //TODO: swap the if for actions points = 0 or player or enemy pass his turn 
            {
                m_currentPlayer = m_currentPlayer + 1 >= m_player.Length ? 0 : m_currentPlayer + 1;
                m_gameManager.m_freeCamera = false;
            }
        }
        
    }
    
    private void UpdateRotation()
    {
        // Rotates the camera around the camera rig pivot in Y axis
        if (Input.GetMouseButton(2))//TODO: better button3
        {
            float rotAngle = m_RotationSeed * Input.GetAxis("Mouse X");
            m_Camera.transform.RotateAround(transform.position, Vector3.up , rotAngle);
        }

    }

    private void UpdateZoomInput() {
        //Smooth move in Y axis for zoom effect
        Vector3 nextPosition = m_Camera.transform.position;

        if (Input.GetAxis("Mouse ScrollWheel") < 0.0f) {
            nextPosition += Vector3.up * m_ZoomSpeed;
        }
        else if (Input.GetAxis("Mouse ScrollWheel") > 0.0f) {
            nextPosition += Vector3.down * m_ZoomSpeed;
        }

        m_Camera.transform.position = Vector3.SmoothDamp(m_Camera.transform.position, nextPosition, ref m_velocity, m_dampTime);
    }

    private void UpdateMovementInput() {
        //Move the position camera rig depeding where is our mouse in the screen or if you're pressing WASD keys
        if (Input.mousePosition.y >= Screen.height * topBarrier || Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * m_ScrollSpeed, Camera.main.transform);
        }

        if (Input.mousePosition.y <= Screen.height * botBarrier || Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Time.deltaTime * m_ScrollSpeed, Camera.main.transform);
        }

        if (Input.mousePosition.x >= Screen.width * leftBarrier || Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * m_ScrollSpeed, Camera.main.transform);
        }

        if (Input.mousePosition.x <= Screen.width * rightBarrier || Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * m_ScrollSpeed, Camera.main.transform);
        }
    }
}
