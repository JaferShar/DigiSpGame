using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaBar : MonoBehaviour
{

    public Slider manaBar;

    private int maxMana = 100;
    private int currentMana;

    private WaitForSeconds regenTik = new WaitForSeconds(0.1f);
    private Coroutine regen;
    public static ManaBar instance;

    void Awake()
    {
        instance = this;
    }

    // Update is called once per frame
    void Start()
    {
        currentMana = maxMana;
        manaBar.maxValue = maxMana;
        manaBar.value = maxMana;
    }
    
    public bool UseMana(int amount) 
    {
        if (currentMana - amount >= 0) {
            currentMana -= amount;
            manaBar.value = currentMana;

            if (regen != null)  StopCoroutine(regen);

            regen = StartCoroutine(RegenMana());
            return true;
        }

        return false;
    }
    private IEnumerator RegenMana()
    {
        yield return new WaitForSeconds(2);

        while(currentMana < maxMana)
        {
            currentMana += maxMana / 100;
            manaBar.value = currentMana;
            yield return regenTik;
        }
        regen = null;
    }
}
