using UnityEngine;

public class FastEnemy : MonoBehaviour
{
    public float speed = 8f;
    public int damage = 5;

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        CastleHealth castle = other.GetComponent<CastleHealth>();

        if (castle != null)
        {
            castle.TakeDamage(damage);
            Destroy(gameObject);
        }
    }
}

