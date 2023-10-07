using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseWeapon : MonoBehaviour
{
    private List<iObserver> observers = new List<iObserver>();

    public void AddObserver(iObserver observer)
    {
        observers.Add(observer);
    }
     public void RemoveObserver(iObserver observer) 
    {
        observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (iObserver observer in observers)
        {
            observer.OnNotify();
        }
    }
}
