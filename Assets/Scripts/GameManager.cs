using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    private LinkedList<Player> m_Players = new LinkedList<Player>(); //TODO: change list to arraid
    private Player m_CurrentPlayer;

    public bool m_fightMode = true; //for the moment, true.
    public bool m_freeCamera = true; //let free the camera when get the target

    // Use this for initialization
    void Start () {
        Player[] players = FindObjectsOfType<Player>();
        foreach (Player pl in players) {
            m_Players.AddLast(pl);
        }
	}
	
	// Update is called once per frame
	void Update () {
        LinkedListNode<Player> current = m_Players.First;
        current = current.Next;
	}
}
