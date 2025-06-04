using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float projectileSpeed = 10.0f;
    Vector3 playerPosition;

    void Awake()
    {
        gameObject.SetActive(false);
    }

    void Start()
    {
        playerPosition = player.transform.position;
    }

    void Update()
    {
        MoveToPlayer();
        DestroyWhenReached();
    }

    void DestroyWhenReached()
    {
        if (transform.position == playerPosition)
        {
            Destroy(gameObject);
        }

    }

    void MoveToPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, Time.deltaTime * projectileSpeed);
    }
}
