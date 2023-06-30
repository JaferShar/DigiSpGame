using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellLife : MonoBehaviour
{
    public float spellLife = 10f;
    public GameObject explosion;
    public GameObject currExpl;


    void Awake()
    {
        Destroy(gameObject, spellLife);
    }
    
    void OnCollisionEnter(Collision other) {

        if (other.gameObject.name.Equals("Enemy")) {
            Destroy(other.gameObject);
        }
        
        currExpl = Instantiate(explosion, gameObject.transform.position, Quaternion.identity);
        StartCoroutine(EndParticle());
        Destroy(gameObject);
    }

    private IEnumerator EndParticle()
    {
        yield return new WaitForSeconds(2);
        Destroy(currExpl);
    }

}