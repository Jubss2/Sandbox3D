using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponEvents : MonoBehaviour
{
    public static event Action<WeaponEvents> OnWeaponEvent;

    [SerializeField] private string _weaponName;

    public string WeaponName { get { return _weaponName; } }

    private void OnTriggerEnter(Collider other)
    {
        if (OnWeaponEvent != null)
            OnWeaponEvent(this);
    }
}
