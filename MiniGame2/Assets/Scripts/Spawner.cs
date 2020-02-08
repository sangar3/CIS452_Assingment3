using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spawner : MonoBehaviour
{
   
    public GameObject[] obstaclepatterns;
    
 
    private float timebtwSpawn;
    public float startTimebtwSpawn;
    public float decreaseTime;
    public float minTime = 0.65f;

    




    private void Update()
    {
       
        if(timebtwSpawn <=0)
        {
            int rand = Random.Range(0, obstaclepatterns.Length);
            Instantiate(obstaclepatterns[rand], transform.position, Quaternion.identity);
            timebtwSpawn = startTimebtwSpawn;
            if(startTimebtwSpawn > minTime)
            {
                startTimebtwSpawn -= decreaseTime;
            }
           
        }
        else
        {
            timebtwSpawn -= Time.deltaTime;
        }
      
    }
        

}
