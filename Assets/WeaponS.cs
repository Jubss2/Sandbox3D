using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponS : MonoBehaviour, iObserver
{
    // Start is called before the first frame update
    public void OnNotify()
    {
        if (GameObject.FindGameObjectWithTag("Weapon") != null)
        {
            Debug.Log("Pego arma");
            Destroy(gameObject);
        }
    }
}
