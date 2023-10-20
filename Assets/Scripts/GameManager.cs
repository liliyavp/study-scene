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
    public ParticleSystem particleSystem;

    Animator drawer1Animator;
    Animator drawer2Animator;
    Animator miniDrawerAnimator;
    Animator bookAnimator;
    Animator journalAnimator;
    

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
        drawer1Animator = drawer1.GetComponent<Animator>();
        drawer2Animator = drawer2.GetComponent<Animator>();
        miniDrawerAnimator = miniDrawer.GetComponent<Animator>();
        bookAnimator = book.GetComponent<Animator>();
        journalAnimator = journal.GetComponent<Animator>();


        drawer1Animator.Play("drawer_1_idle",0,0);
        drawer2Animator.Play("drawer_2_idle",0,0);
        miniDrawerAnimator.Play("Idle",0,0);
    }

    void Update()
    {
        
    }

    public void CheckRaycast(string objectName)
    {
        Debug.Log("GameManager received rayhit " + objectName);

        switch(objectName)
        {
            case "FlippyBook":
                FlipPage();
                break;
            case "Drawer":
                OpenDrawer1();
                break;
            case "Drawer 2":
                OpenDrawer2();
                break;
            case "mini drawer":
                OpenMiniDrawer();
                break;
            case "Candle":
                ExtinguishCandle();
                break;
            case "BigCrystal":
                TapCrystal();
                break;
        }
    }

    

    public void OpenDrawer1()
    {
        drawer1Animator.SetBool("OpenDrawer1", true);
        StartCoroutine(WaitWhileDrawerOpens(1));
        drawer1Animator.SetBool("IdleOpenDrawer1", true);
        StartCoroutine(WaitWhileDrawerOpens(5));
        drawer1Animator.SetBool("CloseDrawer1", true);
        //set up drawer closes bool and it will be fine probably
    }

    public void OpenDrawer2() 
    { 
        drawer2Animator.SetBool("OpenDrawer2", true);
        StartCoroutine(WaitWhileDrawerOpens(1));
        drawer2Animator.SetBool("IdleOpenDrawer2", true);
        StartCoroutine(WaitWhileDrawerOpens(5));
        drawer2Animator.SetBool("CloseDrawer2", true);
    }

    public void OpenMiniDrawer() 
    { 
        miniDrawerAnimator.SetBool("OpenMiniDrawer", true);
        StartCoroutine(WaitWhileDrawerOpens(1));
        miniDrawerAnimator.SetBool("IdleOpenMiniDrawer", true);
        StartCoroutine(WaitWhileDrawerOpens(5));
        miniDrawerAnimator.SetBool("CloseMiniDrawer", true);
    }

    public void FlipPage()
    {

    }

    public void ExtinguishCandle()
    {
        candleLight.enabled = false;
        particleSystem.Stop();
    }

    public void TapCrystal()
    {

    }

    IEnumerator WaitWhileDrawerOpens(int wait)
    {
        yield return new WaitForSeconds(wait);
    }

    

}
