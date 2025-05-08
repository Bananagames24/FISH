using TMPro;
using UnityEngine;

public class PlayerColect : MonoBehaviour
{
    private int amountColected = 0;
    [SerializeField] private TextMeshProUGUI showColoected;
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
        Destroy(gameObject);
    }
}
