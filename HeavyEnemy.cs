using UnityEngine;

public class HeavyEnemy : MonoBehaviour
{
    public float speed = 2f;
    public int damage = 20;

    void Start()
    {
        GetComponent<SpriteRenderer>().color = Color.black;
    }

    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}