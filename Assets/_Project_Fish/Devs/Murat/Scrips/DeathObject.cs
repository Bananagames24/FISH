using UnityEngine;

public class DeathObject : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag=="Player")
        {
            PlayerColect playerColect = collision.transform.GetComponent<PlayerColect>();
            playerColect.Death();
        }
    }
}
