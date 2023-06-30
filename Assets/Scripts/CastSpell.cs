using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class CastSpell : MonoBehaviour
{
    [Header("References")]
    public Transform cam;
    public Transform castPoint;
    public GameObject spell;
    public Slider manaBar;

    [Header("Settings")]
    public float throwCooldown;

    [Header("Casting")]
    public KeyCode castKey = KeyCode.Mouse0;
    public float spellForce;
    public float throwUpwardForce;

    bool readyToCast;

    private void Start()
    {
        readyToCast = true;
    }

    private void Update()
    {
        if (Input.GetKeyDown(castKey) && readyToCast && manaBar.value >= 20)
        {
            Cast();
        }
    }

    private void Cast()
    {

        readyToCast = false;

        GameObject projectile = Instantiate(spell, castPoint.position, spell.transform.rotation);

        // get rigidbody component
        Rigidbody projectileRb = projectile.GetComponent<Rigidbody>();
        // calculate direction
        Vector3 forceDirection = castPoint.forward;
        Vector3 forceToAdd = forceDirection * spellForce;

        projectileRb.AddForce(forceToAdd, ForceMode.Impulse);

        ManaBar.instance.UseMana(20);
        Invoke(nameof(ResetThrow), throwCooldown);

    }

    private void ResetThrow()
    {
        readyToCast = true;
    }
}