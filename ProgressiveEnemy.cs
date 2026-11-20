using UnityEngine;

public class ProgressiveEnemy : MonoBehaviour
{
    public float speed = 1f;
    public int damage = 10;

    void Update()
    {
        speed += 0.5f * Time.deltaTime;
        transform.position += Vector3.left * speed * Time.deltaTime;
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
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

