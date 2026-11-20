using UnityEngine;
using TMPro;
using System.Collections;

public class CastleHealth : MonoBehaviour
{
    public int health = 100;

    public TextMeshProUGUI damageText;

    public void TakeDamage(int damage)
    {
        health -= damage;

        Debug.Log("Castle Health: " + health);

        StartCoroutine(ShowDamage(damage));

        if (health <= 0)
        {
            health = 0;
            Debug.Log("GAME OVER");
        }
    }

    IEnumerator ShowDamage(int damage)
    {
        damageText.gameObject.SetActive(true);

        damageText.text = "-" + damage;

        yield return new WaitForSeconds(1f);

        damageText.gameObject.SetActive(false);
    }
}


