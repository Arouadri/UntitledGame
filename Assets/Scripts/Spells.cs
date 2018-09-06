using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Spells : ScriptableObject {

    public abstract void Fire(GameObject emitter);
}
