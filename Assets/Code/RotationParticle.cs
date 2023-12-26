using UnityEngine;

public class RotationParticle : MonoBehaviour
{
    [SerializeField] private Transform _enemyCube;

    private void Update()
    {
        transform.LookAt(_enemyCube);
    }
}
