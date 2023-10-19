using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    public GameObject drawer1;
    public GameObject drawer2;
    public GameObject miniDrawer;
    public GameObject book;
    public GameObject journal;
    public GameObject candle;
    public GameObject crystal;
    public Light candleLight;

    Animation drawer1Animation;
    Animation drawer2Animation;
    Animation miniDdrawerAnimation;
    Animation bookAnimation;
    Animation journalAnimation;
    

    public bool drawer1Open = false;
    public bool drawer2Open = false;

    string rayObjName = "";

    /*
    private GameManager() { };
    private static GameManager instance = null;
    public static GameManager Instance
    {
        get
        {
            if (instance == null)
            {
                instance = new GameManager();
            }
            return instance;
        }
    }

    */



    void Start()
    {
        drawer1Animation = drawer1.GetComponent<Animation>();
        drawer2Animation = drawer2.GetComponent<Animation>();
        miniDdrawerAnimation = miniDrawer.GetComponent<Animation>();
        bookAnimation = book.GetComponent<Animation>();
        journalAnimation = journal.GetComponent<Animation>();


        drawer1Animation.Play("drawer_1_idle");
        drawer2Animation.Play("drawer_2_idle");
        miniDdrawerAnimation.Play("Idle");
    }

    void Update()
    {
        
    }

    public void CheckRaycast(string objectName)
    {
        Debug.Log("GameManager received rayhit " + objectName);
    }

    /*

    public void OpenDrawer1()
    {

    }

    public void CloseDrawer1() 
    {
        
    }

    public void Drawer1Idle()
    {

    }

    public void OpenDrawer2() 
    { 
    
    }

    public void CloseDrawer2()
    {

    }

    public void OpenMiniDrawer() 
    { 
    
    }

    public void CloseMiniDrawer() 
    { 
    
    }

    public void FlipPage()
    {

    }

    public void ExtinguishCandle()
    {

    }

    public void TapCrystal()
    {

    }

    */

}
