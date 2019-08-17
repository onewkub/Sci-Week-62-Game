﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseTheWay : MonoBehaviour
{
    [Header("WayPoint")]
    public GameObject Left;
    public GameObject Right;
    public GameObject Forward;
    public GameObject Backward;
    [Header("UI")]
    public GameObject LeftButton;
    public GameObject RightButton; 
    public GameObject ForwardButton;
    public GameObject BackwardButton;
	private float Countdown;
    private void Start()
    {
		//CheckTheWay();
		Countdown = 5;
    }
    private void CheckTheWay()
    {
        LeftButton.SetActive(Left != null);
        RightButton.SetActive(Right != null);
        ForwardButton.SetActive(Forward != null);
        BackwardButton.SetActive(Backward != null);
    }
    private void Update()
    {
		Countdown -= Time.deltaTime;
		if (!WalkingPath.Instance.haveChoose)
			CheckTheWay();
		if (Countdown <= 0)
		{
			int index = Random.Range(0, 4);
			Debug.Log(index);
			if(index == 0 && Forward != null)
			{
				Debug.Log("Choose Forward");

				WalkingPath.Instance.ChoosenPosition = Forward;
				WalkingPath.Instance.haveChoose = true;
				if (RightButton != null)
					RightButton.SetActive(false);
				if (LeftButton != null)
					LeftButton.SetActive(false);
				if (BackwardButton != null)
					BackwardButton.SetActive(false);
				this.enabled = false;
			}
			else if(index == 1 && Backward != null)
			{
				Debug.Log("Choose Backward");

				WalkingPath.Instance.ChoosenPosition = Backward;
				WalkingPath.Instance.haveChoose = true;
				if (RightButton != null)
					RightButton.SetActive(false);
				if (ForwardButton != null)
					ForwardButton.SetActive(false);
				if (ForwardButton != null)
					ForwardButton.SetActive(false);
				this.enabled = false;
			}
			else if(index == 2 && Left != null)
			{
				Debug.Log("Choose Left");

				WalkingPath.Instance.ChoosenPosition = Left;
				WalkingPath.Instance.haveChoose = true;
				if (RightButton != null)
					RightButton.SetActive(false);
				if (ForwardButton != null)
					ForwardButton.SetActive(false);
				if (BackwardButton != null)
					BackwardButton.SetActive(false);
				//gameObject.SetActive(false);
				this.enabled = false;
			}
			else if(index == 3 && Right != null)
			{
				WalkingPath.Instance.ChoosenPosition = Right;
				WalkingPath.Instance.haveChoose = true;
				if (LeftButton != null)
					LeftButton.SetActive(false);
				if (ForwardButton != null)
					ForwardButton.SetActive(false);
				if (BackwardButton != null)
					BackwardButton.SetActive(false);
				this.enabled = false;
			}
		}

        if (Input.GetButtonDown("Left") && Left != null)
        {
            Debug.Log("Choose Left");

            WalkingPath.Instance.ChoosenPosition = Left;
            WalkingPath.Instance.haveChoose = true;
            if(RightButton != null)
                RightButton.SetActive(false);
            if(ForwardButton != null)
                ForwardButton.SetActive(false);
            if(BackwardButton != null)
                BackwardButton.SetActive(false);
			//gameObject.SetActive(false);
			this.enabled = false;
        }
        else if (Input.GetButtonDown("Right") && Right != null)
        {
            Debug.Log("Choose Right");
            
            WalkingPath.Instance.ChoosenPosition = Right;
            WalkingPath.Instance.haveChoose = true;
            if (LeftButton != null)
                LeftButton.SetActive(false);
            if (ForwardButton != null)
                ForwardButton.SetActive(false);
            if (BackwardButton != null)
                BackwardButton.SetActive(false);
			this.enabled = false;

			//gameObject.SetActive(false);



		}
		else if (Input.GetButtonDown("Up") && Forward != null)
        {
            Debug.Log("Choose Forward");

            WalkingPath.Instance.ChoosenPosition = Forward;
            WalkingPath.Instance.haveChoose = true;
            if (RightButton != null)
                RightButton.SetActive(false);
            if (LeftButton != null)
                LeftButton.SetActive(false);
            if (BackwardButton != null)
                BackwardButton.SetActive(false);
			this.enabled = false;


			//gameObject.SetActive(false);


		}
		else if (Input.GetButtonDown("Down") && Backward != null)
        {
            Debug.Log("Choose Backward");

            WalkingPath.Instance.ChoosenPosition = Backward;
            WalkingPath.Instance.haveChoose = true;
            if (RightButton != null)
                RightButton.SetActive(false);
            if (ForwardButton != null)
                ForwardButton.SetActive(false);
            if (ForwardButton != null)
                ForwardButton.SetActive(false);
			this.enabled = false;

			//gameObject.SetActive(false);

		}
	}
}
