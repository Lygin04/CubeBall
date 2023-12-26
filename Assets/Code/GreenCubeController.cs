using UnityEngine;

public class GreenCubeController : MonoBehaviour
{
    public float speed = 1f;
    
    private void FixedUpdate()
    {
        float x = Input.GetAxis("ArrowHorizontal");
        float z = Input.GetAxis("ArrowVertical");
        Vector3 move = new Vector3(x, 0, z);
        move = Vector3.ClampMagnitude(move, 1);
        transform.Translate(move * (speed * Time.deltaTime));
    }
}
