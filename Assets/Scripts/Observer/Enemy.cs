using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : BaseWeapon
{
    private Destroy[] _enemy;

    private WeaponS[] _weapon;
    public void Awake()
    {
        _enemy = FindObjectsOfType<Destroy>();
        _weapon = FindObjectsOfType<WeaponS>();
    }

    private void OnEnable()
    {
        foreach(iObserver enemy in _enemy)
        {
            AddObserver(enemy);
        }
        foreach (iObserver w in _weapon)
        {
            AddObserver(w);
        }
    }
    private void OnDisable()
    {
        foreach (iObserver enemy in _enemy)
        {
            RemoveObserver(enemy);
        }
        foreach (iObserver w in _weapon)
        {
            RemoveObserver(w);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
            Notify();
            Debug.Log("alo");
    }
}
