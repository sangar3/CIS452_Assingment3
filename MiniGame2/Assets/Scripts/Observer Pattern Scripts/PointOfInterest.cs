/*
     * (Santiago Garcia II)
     * (PointOfInterest.cs)
     * (Assignment 3)
     * (the main subject because when the player hits a obstacle it calls the subject's notify method for the observer )
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PointOfInterest : Subject
{
    [SerializeField]
    private string poiName;

    void OnTriggerEnter2D(Collider2D other) // notifys the observer when player is hit by obstacle
    {
        if (other.CompareTag("Obstacle"))
        {
            Notify(poiName, NotificationType.PlayerFeedBack);
           
        }
    }



}
