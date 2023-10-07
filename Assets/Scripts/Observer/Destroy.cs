using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour, iObserver
{
    GameObject player;

    float speed = 4.0f;
    public void OnNotify()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        Vector3.MoveTowards(transform.position, player.transform.position, speed *Time.deltaTime);
        Debug.Log("fun");
       
    }

}
