using TMPro;
using UnityEngine;

public class PlayerColect : MonoBehaviour
{
    private int amountColected = 0;
    [SerializeField] private TextMeshProUGUI showColoected;
    [SerializeField] private GameObject Spawnpoint;
    Rigidbody rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        showColoected.text = ""+amountColected;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "colectable")
        {
            amountColected++;
            Destroy(collision.gameObject);
        }
    }
    public void Death()
    {
        transform.SetPositionAndRotation(Spawnpoint.transform.position, Spawnpoint.transform.rotation);
        rb.angularVelocity = Vector3.zero;
        rb.linearVelocity = Vector3.zero;
    }
}
