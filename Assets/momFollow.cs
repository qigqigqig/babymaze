using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class momFollow : MonoBehaviour
{

    public Transform Player;
    int MoveSpeed = 10;
    int MaxDist = 10;
    int MinDist = 10;




    void Start()
    {

    }

    void Update()
    {
      // Debug.Log(Vector3.Distance(transform.position, Player.position));
        if (Vector3.Distance(transform.position, Player.position) <= MinDist)
        {
            transform.LookAt(Player);

            transform.position += transform.forward * MoveSpeed * Time.deltaTime;

        }
    }
}
