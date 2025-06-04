using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] GameObject projectile;
    [SerializeField] GameObject projectile1;
    [SerializeField] GameObject projectile2;
    [SerializeField] GameObject projectile3;
    [SerializeField] GameObject projectile4;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            if (projectile != null)
            {
                projectile.SetActive(true);
            }
            if (projectile1 != null)
            {
                projectile1.SetActive(true);
            }
            if (projectile2 != null)
            {
                projectile2.SetActive(true);
            }
            if (projectile3 != null)
            {
                projectile3.SetActive(true);
            }
            if (projectile4 != null) {
                projectile4.SetActive(true);
            }
           
        }
    }
}
