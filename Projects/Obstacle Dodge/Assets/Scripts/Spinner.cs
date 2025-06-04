using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] float spinningSpeedX = 0f;
    [SerializeField] float spinningSpeedY = 1f;
    [SerializeField] float spinningSpeedZ = 0f;

    void Update()
    {
        transform.Rotate(spinningSpeedX, spinningSpeedY, spinningSpeedZ);
    }
}
