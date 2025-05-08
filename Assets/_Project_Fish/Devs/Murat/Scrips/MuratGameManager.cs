using System;
using System.Collections.Generic;
using UnityEngine;

public class MuratGameManager : MonoBehaviour
{
    [SerializeField] private GameObject Umbrella;
    [SerializeField] private List<GameObject> MovePos;
    private float timer = 0.0f;
    private int om = 0;
    private void Start()
    {
        
    }
    private void Update()
    {
        if (timer > 5f)
        {
            switch (om)
            {
                case 0:
                    GameObject temp = Instantiate(Umbrella, MovePos[0].transform.position, Quaternion.identity);
                    Umbrella umbrella1 = temp.GetComponent<Umbrella>();
                    for (int i = 0; i < MovePos.Count * 0.5f; i++)
                    {
                        umbrella1.pos.Add(MovePos[i]);
                    }
                    Destroy(temp,15f);
                    om = 1;
                    break;
                case 1:
                    GameObject temp2 = Instantiate(Umbrella, MovePos[4].transform.position, Quaternion.identity);
                    Umbrella umbrella2 = temp2.GetComponent<Umbrella>();
                    for (int i = Mathf.FloorToInt(MovePos.Count * 0.5f) ;i< MovePos.Count; i++)
                    {
                        umbrella2.pos.Add(MovePos[i]);
                    }
                    Destroy(temp2, 15f);
                    om = 0;
                    break;
                default:
                    break;
            }
            timer = 0;
        }else
        {
            timer += Time.deltaTime;
        }
    }
}
