using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField] private Transform player;
    public float rotationSpeed = 100f;
    public Camera mainCamera;

    void Update()
    {
        // TOP DOWN CAMERA
        transform.position = new Vector3(player.position.x, player.position.y + 3, player.position.z - 6);
        if (Input.GetMouseButton(0) || Input.GetMouseButton(1))
        {
            
        }
    }
}
