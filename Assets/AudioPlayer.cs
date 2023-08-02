using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using System;
using UnityEngine.Video;

public class AudioPlayer : MonoBehaviour
{

   
    public Text nowTime;           
    public Text allTime;          
    public Slider slid;             
    public Transform buttons;      
    public AudioClip[] auc;        
    public AudioSource aus;          
    private int index;               

    private int currentHour, currentMinute, currentSecond;          
    private int clipHour, clipMinute, clipSecond;                    
   

    public GameObject play;
    public GameObject pause;

   

    void Start()
    {
        aus.Stop();
        
        slid.onValueChanged.AddListener(delegate
        {
            if (slid.value == 1)                                    
                return;
             aus.time = slid.value * aus.clip.length;   
            
        });
        foreach (Transform go in buttons)                         
        {
            go.GetComponent<Button>().onClick.AddListener(delegate   
            {
                switch (go.name)
                {
                    case "lastM":        
                        LastMusic();
                        pause.gameObject.SetActive(true);
                        play.gameObject.SetActive(false);
                        break;
                    case "pause":      
                        Pause();
                        pause.gameObject.SetActive(false);
                        play.gameObject.SetActive(true);
                        break;
                    case "play":        
                        Play();
                        play.gameObject.SetActive(false);
                        pause.gameObject.SetActive(true);

                        break;
                    case "nextM":       
                        NextMusic();
                        pause.gameObject.SetActive(true);

                        play.gameObject.SetActive(false);
                        break;
                }
            });
        }
    }
    void Update()
    {
        nowtime();
        alltime();
       
         nowMusic();
    }
    void nowtime() 
    {
        currentHour = (int)aus.time / 3600;
        currentMinute = (int)(aus.time - currentHour * 3600) / 60; 
        
        currentSecond = (int)(aus.time - currentHour * 3600 - currentMinute * 60);
        


        nowTime.text = string.Format("{0:D2}:{1:D2}:{2:D2} ",
            currentHour, currentMinute, currentSecond);
         slid.value = aus.time / aus.clip.length;
        
    }
    void alltime() 
    {
         clipHour = (int)aus.clip.length / 3600;
        

         clipMinute = (int)(aus.clip.length - clipHour * 3600) / 60; 
        

        clipSecond = (int)(aus.clip.length - clipHour * 3600 - clipMinute * 60);
        

        allTime.text = string.Format("{0:D2}:{1:D2}:{2:D2}",
            clipHour, clipMinute, clipSecond);
    }
    private void LastMusic()            
    {
        index--;                         
        if (index == -1)
            index = auc.Length - 1;
        aus.clip = auc[index]; 

        slid.value = 0;                 
        aus.Play();                  
    }
    private void Pause()                 
    {
         aus.Pause();
         
    }
    private void Play()                  
    {
         aus.Play();
       

    }
    private void NextMusic()             
    {
        index++;                        
        
        if (index == auc.Length)
            index = 0;
        aus.clip = auc[index];          
        slid.value = 0;                
        aus.Play();                     
    }
    void nowMusic()                    
    {
        AudioClip clip = aus.clip;     
        index = Array.IndexOf(auc, clip); 
        Slider();                         
    }
    void Slider() 
    {
        if (currentHour == clipHour && currentMinute == clipMinute && currentSecond == clipSecond)
        {
            NextMusic(); 
        }
    }
}
 