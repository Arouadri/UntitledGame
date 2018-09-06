using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Spells/ProjectileSpell")]
public class ProjectileSpell : Spells {
    
    public Rigidbody m_projectile;
    public float m_speed;

    public override void Fire(GameObject emitter)
    {
        emitter.GetComponent<ActionEmitter>().Launch(this.m_projectile, this.m_speed);
    }
}
