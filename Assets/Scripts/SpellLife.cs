using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellLife : MonoBehaviour
{
    public float spellLife = 10f;
    public GameObject explosion;


    void Awake()
    {
        Destroy(gameObject, spellLife);
    }
    
    void OnCollisionEnter(Collision other) {

        if (other.gameObject.name.Equals("Enemy")) {
            Destroy(other.gameObject);
        }
        
        Instantiate(explosion, gameObject.transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

}