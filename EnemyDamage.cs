
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public int damage = 5;

    private bool hasHit = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (hasHit) return;

        CastleHealth castle =
            other.GetComponent<CastleHealth>();

        if (castle != null)
        {
            hasHit = true;

            castle.TakeDamage(damage);

            Destroy(gameObject);
        }
    }
}

