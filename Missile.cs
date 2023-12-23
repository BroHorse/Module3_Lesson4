using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public float speed;

    void Update()
    {
        //Клон огненного шара уничтожается через 3 секунды
        Destroy(gameObject, 3);
        //Каждый кадр позиция шара обновляется
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    void OnTriggerEnter(Collider other) {

        //Враг уничтожается
        Enemy enemy = other.GetComponent<Enemy>();
        Destroy(enemy.gameObject);

        //Снаряд уничтожается
        Destroy(gameObject);

    }

}
