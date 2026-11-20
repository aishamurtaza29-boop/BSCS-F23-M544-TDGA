using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 5f;
    public int damage = 10;

    void Update()
    {
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



