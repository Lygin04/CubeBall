using UnityEngine;

public class RedCubeController : MonoBehaviour
{
    public float speed = 1f;
    
    private void FixedUpdate()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        Vector3 move = new Vector3(x, 0, z);
        move = Vector3.ClampMagnitude(move, 1);
        transform.Translate(move * (speed * Time.deltaTime));
    }
}
