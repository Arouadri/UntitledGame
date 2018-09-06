using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionEmitter : MonoBehaviour {

    //

    //para lanzar un proyectil
    public void Launch(Rigidbody projectile, float speed)
    {
        //clona el rigidbody del parametro projectile
        Rigidbody clonedProjectile = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;

        //TODO: cambiar para que sea donde clike la camara
        //direccion y velocidad a la que ira el rigidbody clonado
        clonedProjectile.AddForce(transform.forward * speed);
    }

    //TODO: Hacer linea imaginaria para hacer ataques melee e interacciones con objetos y personajes
    public void Cast(Ray ray, float range)
    {
        ray.origin = transform.position;
        ray.direction = transform.forward;
        Physics.Raycast(ray, range);

        //dibuja el raycast (mirar si se ve en el juego o solo en la escena)
        Debug.DrawRay(ray.origin, ray.direction * range, Color.red, 5);
    }
}
