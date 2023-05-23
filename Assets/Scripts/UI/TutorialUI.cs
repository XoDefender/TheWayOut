using Cinemachine;
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.ProBuilder.MeshOperations;
using UnityEngine.SceneManagement;

public class TutorialUI : MonoBehaviour
{

    private bool e = false;
    private bool t1 = false;
    private bool t2 = false;
    private bool t3 = false;
    private bool t4 = false;
    private bool t5 = false;
    private bool t6 = false;
    private bool t7 = false;
    private bool t8 = false;
    private bool t9 = false, tt9 = true, tt8 = true, tt7 = true;
    private bool t10 = false, tt10 = true;
    private bool t11 = false, tt11 = true;
    private bool t12 = false, tt12 = true;
    private bool t13 = false, tt13 = true;
    private bool t14 = false, tt14 = true;
    private bool t15 = false, tt15 = true;
    private bool t16 = false, tt16 = true;
    private bool t17 = false, tt17 = true;
    private bool t18 = false, tt18 = true;


    public GameObject tut1;
    public GameObject tut2;
    public GameObject tut3;
    public GameObject tut4;
    public GameObject tut5;
    public GameObject tut6;
    public GameObject tut7;
    public GameObject tut8;
    public GameObject tut9;
    public GameObject tut10;
    public GameObject tut11;
    public GameObject tut12;
    public GameObject tut13;

    public GameObject HintBtn;
    private void Start()
    {
        tut1.SetActive(true);
        tut2.SetActive(false);
        tut3.SetActive(false);
        tut4.SetActive(false);
        tut5.SetActive(false);
        tut6.SetActive(false);
        tut7.SetActive(false);
        tut8.SetActive(false);
        tut9.SetActive(false);
        tut10.SetActive(false);
        tut11.SetActive(false);
        tut12.SetActive(false);
        tut13.SetActive(false);

        HintBtn.SetActive(false);

        UnitActionSystem.Instance.OnBusyActionChanged += UnitActionSystem_OnBusyActionChanged;
    }
    void Update()
    {
        esc();
        if (t18)
        {
            tut13.SetActive(false);
        }
        else
        if (t17)//esc
        {
            tut12.SetActive(false);
            tut13.SetActive(tt17);
        }
        else if (t16)//win lose
        {
            tut11.SetActive(false);
            tut12.SetActive(tt16);
        }
        else if (t15)//enemy turn
        {
            tut10.SetActive(false);
            tut11.SetActive(tt15);
        }
        else if (t14)//end turn
        {
            tut9.SetActive(false);
            tut10.SetActive(tt14);
        }
        else if (t13)//take
        {
            tut8.SetActive(false);
            tut9.SetActive(tt14);
        }
        else if (t12)
        {
            tut7.SetActive(false);
            tut8.SetActive(tt13);
        }
        else if (t11)
        {
            tut6.SetActive(false);
            tut7.SetActive(tt12);
        }
        else if (t10)
        {
            tut5.SetActive(false);
            tut6.SetActive(tt11);
        }
        else if (t9)
        {
            tut4.SetActive(false);
            tut5.SetActive(tt10);
        }
        else if (t7 && t8)
        {
            tut3.SetActive(false);

            tut4.SetActive(tt9);
        }
        else if (t5 && t6)
        {
            tut2.SetActive(false);
            tut3.SetActive(tt8);

            HandleZooming();
        }
        else if (t1 && t2 && t3 && t4)
        {
            tut1.SetActive(false);
            tut2.SetActive(tt7);
            HandleRotation();
        }
        else
            HandleMovement();

    }

    public void Finish()
    {
        SceneManager.LoadScene(0);
    }

    public void HideHint()
    {
        if (t17)
            tt17=false;
        else
        if (t16)
            tt16 = false;
        else
        if (t15)
            tt15 = false;
        else
        if (t14)
            tt14 = false;
        else
        if (t13)
            tt14 = false;
        else
        if (t12)
            tt13 = false;
        else
        if (t11)
            tt12 = false;
        else
        if (t10)
            tt11 = false;
        else
        if (t9)
            tt10 = false;
        else
        if (t7 && t8)
            tt9 = false;
        else
            if (t5 && t6)
            tt8=false;
        else
            if (t1 && t2 && t3 && t4)
            tt7=false;

        HintBtn.SetActive(true);
    }

    public void ShowHint()
    {
        if (t17)
            tt17 = true;
        else
        if (t16)
            tt16=true;
        else
        if (t15)
            tt15=true;
        else
        if (t14)
            tt14 = true;
        else
        if (t13)
            tt14 = true;
        else
        if (t12)
            tt13 = true;
        else
        if (t11)
            tt12 = true;
        else
        if (t10)
            tt11 = true;
        else
        if (t9)
            tt10 = true;
        else
        if (t7 && t8)
            tt9=true;
        else
            if (t5 && t6)
            tt8=true;
        else
            if (t1 && t2 && t3 && t4)
            tt7=true;
        HintBtn.SetActive(false);
    }

    public void NextHint()
    {
        if (t17)
            t18=true;
        else
        if (t16)
            t17=true;
        else
        if (t15)
            t16=true;
        else
        if (t14)
            t15=true;
    }

    public void esc()
    {
        if (Input.GetKey(KeyCode.Escape) && e==false)
        {
            HideHint();
            e=true;
        }
        else
            if (Input.GetKey(KeyCode.Escape) && e==true)
        {

            ShowHint();
            e=false;

        }

    }

    private void HandleMovement()
    {
        Vector3 moveDirection = new Vector3(0, 0, 0);
        if (Input.GetKey(KeyCode.W))
        {
            t1=true;
        }
        if (Input.GetKey(KeyCode.S))
        {
            t2=true;
        }
        if (Input.GetKey(KeyCode.A))
        {
            t3=true;
        }
        if (Input.GetKey(KeyCode.D))
        {
            t4=true;
        }

    }

    private void HandleRotation()
    {

        if (Input.GetKey(KeyCode.Q))
        {
            t5 = true;
        }
        if (Input.GetKey(KeyCode.E))
        {
            t6 = true;
        }

    }

    private void HandleZooming()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0)
        {
            t7 = true;
            //Debug.Log(Input.mouseScrollDelta.y);

        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0)
        {
            t8 = true;
            //Debug.Log(Input.mouseScrollDelta.y);

        }

    }

    private void UnitActionSystem_OnBusyActionChanged(object sender, bool isBusy)
    {
        //qq();
        if (isBusy && t13)//take
            t14=true;
        else
        if (isBusy && t12)//sword
            t13=true;
        else
        if (isBusy && t11)//grenade
            t12=true;
        else
        if (isBusy && t10)//shoot
            t11=true;
        else
        if (isBusy && t9)//spin
        {
            t10=true;
        }
        else
        if (isBusy && t8)//move
        {
            t9=true;
        }
    }

    private IEnumerator qq()
    {
        yield return new WaitForSeconds(3);
    }
}
