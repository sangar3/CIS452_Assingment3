/*
     * (Santiago Garcia II)
     * (File Name)
     * (FeedbackSystem)
     * (When the player hits a obstacle but i also has low shield would call the observers onNotify method)
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FeedbackSystem : Observer
{
    [SerializeField]
    public GameObject lowshieldhud;
    private bool playerhealthlow = false;

    private void Start()
    {
        
        PlayerPrefs.DeleteAll();
        foreach(var poi in FindObjectsOfType<PointOfInterest>())
        {
            poi.RegisterObserver(this);
        }
    }
    private void Update()
    {
        if (playerhealthlow == true) //showing player feedback
        {
            lowshieldhud.SetActive(true);
        }
    }
    public override void OnNotify(object value, NotificationType notificationType) // tells the observer eveytime the player gets by the meteor but also checks if the player is low health
    {
        if(notificationType == NotificationType.PlayerFeedBack)
        {
            string achievementkey = " achivement-" + value;
            if (PlayerPrefs.GetInt(achievementkey) == 1)
            {
                return;
            }

            PlayerPrefs.SetInt(achievementkey, 1);
            
            Debug.Log("Your ship has low Shield!" + value);
            playerhealthlow = true;


        }
    }


   
}


public enum NotificationType
{
    PlayerFeedBack
}

