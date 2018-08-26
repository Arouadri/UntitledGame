using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    private LinkedList<Player> m_Players = new LinkedList<Player>();
    private Player m_CurrentPlayer;

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
