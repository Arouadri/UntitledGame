using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticSpellGestor : MonoBehaviour {

    public Spells m_fireBall;
    public Spells m_rayo;

	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("1"))
        {
            this.m_fireBall.Fire(this.gameObject);
        }
        if (Input.GetButtonDown("2"))
        {
            this.m_rayo.Fire(this.gameObject);
        }
    }
}
