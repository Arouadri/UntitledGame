using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Spells/RaycastSpell")]
public class RaycastSpell : Spells {

    public float m_range;

    public override void Fire(GameObject emitter)
    {
        emitter.GetComponent<ActionEmitter>().Cast(new Ray(), this.m_range);
    }
}
