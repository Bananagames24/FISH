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
            switch (CheckColect(collision.gameObject))
            {
                case 0:
                    amountColected++;
                    break;
                case 1:
                    break;
                default:
                    break;
            }
            Destroy(collision.gameObject);
        }
    }
    private int CheckColect(GameObject Colect)
    {
        if (Colect.name=="coin")
        {
            return 0;
        }
        else if (Colect.name=="")
        {
            return 1;
        }
        return default;
    }
    public void Death()
    {
        transform.SetPositionAndRotation(Spawnpoint.transform.position, Spawnpoint.transform.rotation);
        rb.angularVelocity = Vector3.zero;
        rb.linearVelocity = Vector3.zero;
    }
}
