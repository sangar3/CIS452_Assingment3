/*
     * (Santiago Garcia II)
     * (Observer.cs)
     * (Assignment 3)
     * (contains data for both abstacts classes of the obserever and subject to send out )
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Observer : MonoBehaviour
{
    public abstract void OnNotify(object value, NotificationType notificationType); //reacts when its notifed
}

public abstract class Subject : MonoBehaviour
{
    private List<Observer> _observers = new List<Observer>(); // list of things that are being observed 

    public void RegisterObserver(Observer observer)
    {
        _observers.Add(observer);
    }

    public void Notify(object value, NotificationType notificationType)
    {
        foreach(var observer in _observers)
        {
            observer.OnNotify(value, notificationType);
        }
    }
 }
