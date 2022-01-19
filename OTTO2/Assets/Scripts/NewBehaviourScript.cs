using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
[Serializable]
public class NewBehaviourScript : MonoBehaviour
{
    
    public GameObject ball1, ball2, ball3, ball4, ball5, ball6, ball7, ball8,ball9,ball10,ball11,ball12,ball13,ball14,ball15,ball16,
        ball17,ball18,ball19,ball20;
    public GameObject levelEnd,startgame;
    public List<GameObject> cylinderlist;
    public List<GameObject> cylinderlist1;
    public List<GameObject> cylinderlist2;
    public List<GameObject> cylinderlist3;
    public List<GameObject> cylinderlist4;
    public List<GameObject> cylinderlist5;
    public List<GameObject> balllist;
    public List<float> listOfPosition = new List<float>();
    public Transform obs, obs1, obs2,obs3,obs4,obs5;
    public ParticleSystem particle1;
    public GameObject cube;
    public float y1 = 0.205f;
    public float y2 = 0.71f;
    public float y3 = 1.226f;
    public float y4 = 1.73f;
    public GameObject cylinder, cylinder1, cylinder2, cylinder3, cylinder4, cylinder5;
    public bool isGameStarted = false;
    public GameObject temp;
    public Text leveltext, levelcomp;
    public int length = 50;
    public int list;
    public bool cylinderlistb = false;
    public bool cylinderlist1b = false;
    public bool cylinderlist2b = false;
    public bool cylinderlist3b = false;
    public bool cylinderlist4b = false;
    public bool cylinderlist5b = false;
    public int balllistcount;
    public int cylinderCount;
    void Start()
    {

         isGameStarted = true;

    InAir.Instance.inAir = false;


        if (!PlayerPrefs.HasKey("level")) { 
            PlayerPrefs.SetInt("level", 1); }

        if (PlayerPrefs.GetInt("level" ) == 2)
        {
            isGameStarted = true;
            leveltext.text = "LEVEL " + PlayerPrefs.GetInt("level");
          
            levelcomp.text = "LEVEL" + " " + PlayerPrefs.GetInt("level") + " " + "COMPLETED!";


        }
        if (PlayerPrefs.GetInt("level") == 3|| PlayerPrefs.GetInt("level") == 4)
        {
            isGameStarted = true;
            leveltext.text = "LEVEL " + PlayerPrefs.GetInt("level");
            Camera.main.transform.position = new Vector3(2.4f, 3.97f, -17.251f);
            levelcomp.text = "LEVEL" +" "+PlayerPrefs.GetInt("level") + " "+"COMPLETED!";
            cube.transform.position = new Vector3(2.27f, transform.position.y, transform.position.z);

        }
        if (PlayerPrefs.GetInt("level") == 5 || PlayerPrefs.GetInt("level") == 6 || PlayerPrefs.GetInt("level") == 7)
        {
            isGameStarted = true;
            leveltext.text = "LEVEL " + PlayerPrefs.GetInt("level");
            Camera.main.transform.position = new Vector3(1.28f, 5.71f, -20.04f);
            levelcomp.text = "LEVEL" + " " + PlayerPrefs.GetInt("level") + " " + "COMPLETED!";
            cube.transform.position = new Vector3(1.39f, transform.position.y, transform.position.z);

        }
        if (PlayerPrefs.GetInt("level") > 7)
        {
            isGameStarted = true;
            leveltext.text = "LEVEL " + PlayerPrefs.GetInt("level");
            Camera.main.transform.position = new Vector3(1.776f, 5.54f, -18.47f);
            levelcomp.text = "LEVEL" + " " + PlayerPrefs.GetInt("level") + " " + "COMPLETED!";
            cube.transform.position = new Vector3(1.72f, 0.59f, -6.22f);
            cylinder.transform.position = new Vector3(2.77f, 1.07f, -2.4f);
            cylinder1.transform.position = new Vector3(1.05f, 1.07f, -2.4f);
            cylinder2.transform.position = new Vector3(5.76f, 1.07f, -2.4f);
            cylinder3.transform.position = new Vector3(-2.21f, 1.07f, -2.4f);
            cylinder4.transform.position = new Vector3(-0.52f, 1.07f, -2.4f);
            cylinder5.transform.position = new Vector3(4.27f, 1.07f, -2.4f);
            obs.transform.position = new Vector3(2.81f, 3.35f, -2.4f);
            obs1.transform.position = new Vector3(1.11f, 3.35f, -2.4f);
            obs2.transform.position = new Vector3(5.78f, 3.35f, -2.4f);
            obs3.transform.position = new Vector3(-2.19f,3.35f, -2.4f);
            obs4.transform.position = new Vector3(-0.52f, 3.35f, -2.4f);
            obs5.transform.position = new Vector3(4.27f, 3.35f, -2.4f);
        }


        levelEnd.SetActive(false);

        listOfPosition.Add(y1);
        listOfPosition.Add(y2);
        listOfPosition.Add(y3);
        listOfPosition.Add(y4);



        balllist.Add(ball1);
        balllist.Add(ball2);
        balllist.Add(ball3);
        balllist.Add(ball4);
        balllist.Add(ball8);
        balllist.Add(ball7);
        balllist.Add(ball6);
        balllist.Add(ball5);

        if (PlayerPrefs.GetInt("level") == 3 || PlayerPrefs.GetInt("level") == 4)
        {
            balllist.Add(ball9);
            balllist.Add(ball10);
            balllist.Add(ball11);
            balllist.Add(ball12);
           
        }
        if (PlayerPrefs.GetInt("level") == 5 || PlayerPrefs.GetInt("level") == 6 || PlayerPrefs.GetInt("level") == 7)
        {
            balllist.Add(ball9);
            balllist.Add(ball10);
            balllist.Add(ball11);
            balllist.Add(ball12);
            balllist.Add(ball13);
            balllist.Add(ball14);
            balllist.Add(ball15);
            balllist.Add(ball16);
            
        }
        if (PlayerPrefs.GetInt("level") > 7)
        {
            balllist.Add(ball9);
            balllist.Add(ball10);
            balllist.Add(ball11);
            balllist.Add(ball12);
            balllist.Add(ball13);
            balllist.Add(ball14);
            balllist.Add(ball15);
            balllist.Add(ball16);
            balllist.Add(ball17);
            balllist.Add(ball18);
            balllist.Add(ball19);
            balllist.Add(ball20);
        }

        AddBall();
    }







    void Update()
    {

        EndGame();
        if (PlayerPrefs.GetInt("level") == 1 || PlayerPrefs.GetInt("level") == 2)
        {
            if ((cylinderlistb == true && cylinderlist1b == true) || (cylinderlistb == true && cylinderlist2b == true) || (cylinderlist1b == true && cylinderlist2b == true))
            {
                particle1.transform.position = cube.transform.position;
                isGameStarted = false;
                levelEnd.SetActive(true);
               

            }
        }
        else if (PlayerPrefs.GetInt("level") == 3 || PlayerPrefs.GetInt("level") == 4)
        {
            if ((cylinderlistb == true && cylinderlist1b == true && cylinderlist3b == true) || (cylinderlistb == true && cylinderlist2b == true && cylinderlist3b == true) || (cylinderlist1b == true && cylinderlist2b == true && cylinderlist3b == true) || (cylinderlistb == true && cylinderlist2b == true && cylinderlist1b == true))
            {
                particle1.transform.position = cube.transform.position;
                isGameStarted = false;
                levelEnd.SetActive(true);
            }

        }
        else if  (PlayerPrefs.GetInt("level") == 5 || PlayerPrefs.GetInt("level") == 6 || PlayerPrefs.GetInt("level") == 7)
        {
            if ((cylinderlistb == true && cylinderlist1b == true && cylinderlist3b == true&& cylinderlist4b == true) || (cylinderlistb == true && cylinderlist2b == true && cylinderlist3b == true && cylinderlist4b == true) || (cylinderlist1b == true && cylinderlist2b == true && cylinderlist3b == true && cylinderlist4b == true)
                || (cylinderlistb == true && cylinderlist1b == true && cylinderlist2b == true && cylinderlist3b == true) || (cylinderlistb == true && cylinderlist1b == true && cylinderlist2b == true && cylinderlist4b == true))
            {
                particle1.transform.position = cube.transform.position;
                isGameStarted = false;
                levelEnd.SetActive(true);
            }

        }
        else if (PlayerPrefs.GetInt("level") > 7)
        {
            if ((cylinderlistb == true && cylinderlist1b == true && cylinderlist3b == true && cylinderlist4b == true && cylinderlist5b == true) || (cylinderlistb == true && cylinderlist2b == true && cylinderlist3b == true && cylinderlist4b == true && cylinderlist5b == true) || (cylinderlist1b == true && cylinderlist2b == true && cylinderlist3b == true && cylinderlist4b == true && cylinderlist5b == true)
                || (cylinderlistb == true && cylinderlist1b == true && cylinderlist2b == true && cylinderlist3b == true && cylinderlist5b == true) || (cylinderlistb == true && cylinderlist1b == true && cylinderlist2b == true && cylinderlist4b == true && cylinderlist5b == true) || (cylinderlistb == true && cylinderlist1b == true && cylinderlist2b == true && cylinderlist3b == true && cylinderlist4b == true))
            {
                particle1.transform.position = cube.transform.position;
                isGameStarted = false;
                levelEnd.SetActive(true);
            }

        }


        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                Touch(hit);
                settleDown(hit);

            }
        }
    }
    public void Touch(RaycastHit touch)
    {
     
        if (touch.transform.gameObject.tag == "Cylinder" && InAir.Instance.inAir == false && cylinderlist.Count != 0 && isGameStarted == true)
        {


            cylinderlist[cylinderlist.Count - 1].transform.DOLocalMove(new Vector3(obs.position.x, obs.position.y, obs.position.z), 0.5f);
            temp = cylinderlist[cylinderlist.Count - 1];
            list = 1;

            Debug.Log("HAVADAYIIM");
            Debug.Log(InAir.Instance.inAir);

        }
        if (touch.transform.gameObject.tag == "Cylinder1" && InAir.Instance.inAir == false && cylinderlist1.Count != 0 && isGameStarted == true)
        {
            cylinderlist1[cylinderlist1.Count - 1].transform.DOLocalMove(new Vector3(obs1.position.x, obs1.position.y, obs1.position.z), 0.5f);
            temp = cylinderlist1[cylinderlist1.Count - 1];
            list = 2;
            Debug.Log("Ben deHAVADAYIIM");
        }
        if (touch.transform.gameObject.tag == "Cylinder2" && InAir.Instance.inAir == false && cylinderlist2.Count != 0 && isGameStarted == true)
        {
            cylinderlist2[cylinderlist2.Count - 1].transform.DOLocalMove(new Vector3(obs2.position.x, obs2.position.y, obs2.position.z), 0.5f);
            temp = cylinderlist2[cylinderlist2.Count - 1];
            list = 3;
        }
        Debug.Log("tag "+touch.transform.gameObject.tag );
        Debug.Log("inair " + InAir.Instance.inAir);
        Debug.Log("count " + cylinderlist3.Count);
       
        if (touch.transform.gameObject.tag == "Cylinder3" && InAir.Instance.inAir == false && cylinderlist3.Count != 0 && isGameStarted == true)
            {
            
                cylinderlist3[cylinderlist3.Count - 1].transform.DOLocalMove(new Vector3(obs3.position.x, obs3.position.y, obs3.position.z), 0.5f);
                temp = cylinderlist3[cylinderlist3.Count - 1];
                list = 4;
            }
        if (touch.transform.gameObject.tag == "Cylinder4" && InAir.Instance.inAir == false && cylinderlist4.Count != 0 && isGameStarted == true)
        {


            cylinderlist4[cylinderlist4.Count - 1].transform.DOLocalMove(new Vector3(obs4.position.x, obs4.position.y, obs4.position.z), 0.5f);
            temp = cylinderlist4[cylinderlist4.Count - 1];
            list = 5;

            Debug.Log("HAVADAYIIMYENÝYÝM");
            Debug.Log(InAir.Instance.inAir);

        }
        if (touch.transform.gameObject.tag == "Cylinder5" && InAir.Instance.inAir == false && cylinderlist5.Count != 0&& isGameStarted == true)
        {


            cylinderlist5[cylinderlist5.Count - 1].transform.DOLocalMove(new Vector3(obs5.position.x, obs5.position.y, obs5.position.z), 0.5f);
            temp = cylinderlist5[cylinderlist5.Count - 1];
            list = 6;

  

        }

    }
    public void settleDown(RaycastHit touch)
    {
        if (touch.transform.gameObject.tag == "Cylinder" && InAir.Instance.inAir == true && cylinderlist.Count < 4)
        {
            temp.transform.DOLocalMove(new Vector3(obs.position.x, obs.position.y, obs.position.z), 0.5f);
            if (temp.transform.position == new Vector3(obs.position.x, obs.position.y, obs.position.z))
            {
                if (list == 1)
                {
                    cylinderlist.RemoveAt(cylinderlist.Count - 1);
                }
                else if (list == 2)
                {
                    cylinderlist1.RemoveAt(cylinderlist1.Count - 1);
                }
                else if (list == 3)
                {
                    cylinderlist2.RemoveAt(cylinderlist2.Count - 1);
                }
                else if (list == 4)
                {
                    cylinderlist3.RemoveAt(cylinderlist3.Count - 1);
                }
                else if (list == 5)
                {
                    cylinderlist4.RemoveAt(cylinderlist4.Count - 1);
                }
                else if (list == 6)
                {
                    cylinderlist5.RemoveAt(cylinderlist5.Count - 1);
                }
                if (cylinderlist.Count == 0)
                {

                    cylinderlist.Add(temp);
                    temp.transform.DOLocalMove(new Vector3(obs.position.x, listOfPosition[0], obs.position.z), 0.5f);


                }
                else if (cylinderlist.Count == 1)
                {

                    cylinderlist.Add(temp);
                    temp.transform.DOLocalMove(new Vector3(obs.position.x, listOfPosition[1], obs.position.z), 0.5f);


                }
                else if (cylinderlist.Count == 2)
                {

                    cylinderlist.Add(temp);
                    temp.transform.DOLocalMove(new Vector3(obs.position.x, listOfPosition[2], obs.position.z), 0.5f);


                }
                else if (cylinderlist.Count == 3)
                {

                    cylinderlist.Add(temp);
                    temp.transform.DOLocalMove(new Vector3(obs.position.x, listOfPosition[3], obs.position.z), 0.5f);


                }

            }
        }
        if (touch.transform.gameObject.tag == "Cylinder1" && InAir.Instance.inAir == true && cylinderlist1.Count < 4)
        {
            temp.transform.DOLocalMove(new Vector3(obs1.position.x, obs1.position.y, obs1.position.z), 0.5f);
            if (temp.transform.position == new Vector3(obs1.position.x, obs1.position.y, obs1.position.z))
            {
                if (list == 1)
                {
                    cylinderlist.RemoveAt(cylinderlist.Count - 1);
                }
                else if (list == 2)
                {
                    cylinderlist1.RemoveAt(cylinderlist1.Count - 1);
                }
                else if (list == 3)
                {
                    cylinderlist2.RemoveAt(cylinderlist2.Count - 1);
                }
                else if (list == 4)
                {
                    cylinderlist3.RemoveAt(cylinderlist3.Count - 1);
                }
                else if (list == 5)
                {
                    cylinderlist4.RemoveAt(cylinderlist4.Count - 1);
                }
                else if (list == 6)
                {
                    cylinderlist5.RemoveAt(cylinderlist5.Count - 1);
                }
                if (cylinderlist1.Count == 0)
                {

                    cylinderlist1.Add(temp);
                    temp.transform.DOLocalMove(new Vector3(obs1.position.x, listOfPosition[0], obs1.position.z), 0.5f);


                }
                else if (cylinderlist1.Count == 1)
                {

                    cylinderlist1.Add(temp);
                    temp.transform.DOLocalMove(new Vector3(obs1.position.x, listOfPosition[1], obs1.position.z), 0.5f);


                }
                else if (cylinderlist1.Count == 2)
                {

                    cylinderlist1.Add(temp);
                    temp.transform.DOLocalMove(new Vector3(obs1.position.x, listOfPosition[2], obs1.position.z), 0.5f);


                }
                else if (cylinderlist1.Count == 3)
                {

                    cylinderlist1.Add(temp);
                    temp.transform.DOLocalMove(new Vector3(obs1.position.x, listOfPosition[3], obs1.position.z), 0.5f);


                }

            }
        }
        if (touch.transform.gameObject.tag == "Cylinder2" && InAir.Instance.inAir == true && cylinderlist2.Count < 4)
        {
            temp.transform.DOLocalMove(new Vector3(obs2.position.x, obs2.position.y, obs2.position.z), 0.5f);
            if (temp.transform.position == new Vector3(obs2.position.x, obs2.position.y, obs2.position.z))
            {
                if (list == 1)
                {
                    cylinderlist.RemoveAt(cylinderlist.Count - 1);
                }
                else if (list == 2)
                {
                    cylinderlist1.RemoveAt(cylinderlist1.Count - 1);
                }
                else if (list == 3)
                {
                    cylinderlist2.RemoveAt(cylinderlist2.Count - 1);
                }
                else if (list == 4)
                {
                    cylinderlist3.RemoveAt(cylinderlist3.Count - 1);
                }
                else if (list == 5)
                {
                    cylinderlist4.RemoveAt(cylinderlist4.Count - 1);
                }
                else if (list == 6)
                {
                    cylinderlist5.RemoveAt(cylinderlist5.Count - 1);
                }
                if (cylinderlist2.Count == 0)
                {

                    cylinderlist2.Add(temp);
                    temp.transform.DOLocalMove(new Vector3(obs2.position.x, listOfPosition[0], obs2.position.z), 0.5f);


                }
                else if (cylinderlist2.Count == 1)
                {


                    cylinderlist2.Add(temp);
                    temp.transform.DOLocalMove(new Vector3(obs2.position.x, listOfPosition[1], obs2.position.z), 0.5f);

                }
                else if (cylinderlist2.Count == 2)
                {

                    cylinderlist2.Add(temp);
                    temp.transform.DOLocalMove(new Vector3(obs2.position.x, listOfPosition[2], obs2.position.z), 0.5f);


                }
                else if (cylinderlist2.Count == 3)
                {

                    cylinderlist2.Add(temp);
                    temp.transform.DOLocalMove(new Vector3(obs2.position.x, listOfPosition[3], obs2.position.z), 0.5f);


                }

            }
        }

        if (touch.transform.gameObject.tag == "Cylinder3" && InAir.Instance.inAir == true && cylinderlist3.Count < 4)
        {
            temp.transform.DOLocalMove(new Vector3(obs3.position.x, obs3.position.y, obs3.position.z), 0.5f);
            if (temp.transform.position == new Vector3(obs3.position.x, obs3.position.y, obs3.position.z))
            {
                if (list == 1)
                {
                    cylinderlist.RemoveAt(cylinderlist.Count - 1);
                }
                else if (list == 2)
                {
                    cylinderlist1.RemoveAt(cylinderlist1.Count - 1);
                }
                else if (list == 3)
                {
                    cylinderlist2.RemoveAt(cylinderlist2.Count - 1);
                }
                else if (list == 4)
                {
                    cylinderlist3.RemoveAt(cylinderlist3.Count - 1);
                }
                else if (list == 5)
                {
                    cylinderlist4.RemoveAt(cylinderlist4.Count - 1);
                }
                else if (list == 6)
                {
                    cylinderlist5.RemoveAt(cylinderlist5.Count - 1);
                }
                if (cylinderlist3.Count == 0)
                {

                    cylinderlist3.Add(temp);
                    temp.transform.DOLocalMove(new Vector3(obs3.position.x, listOfPosition[0], obs3.position.z), 0.5f);


                }
                else if (cylinderlist3.Count == 1)
                {


                    cylinderlist3.Add(temp);
                    temp.transform.DOLocalMove(new Vector3(obs3.position.x, listOfPosition[1], obs3.position.z), 0.5f);

                }
                else if (cylinderlist3.Count == 2)
                {

                    cylinderlist3.Add(temp);
                    temp.transform.DOLocalMove(new Vector3(obs3.position.x, listOfPosition[2], obs3.position.z), 0.5f);


                }
                else if (cylinderlist3.Count == 3)
                {

                    cylinderlist3.Add(temp);
                    temp.transform.DOLocalMove(new Vector3(obs3.position.x, listOfPosition[3], obs3.position.z), 0.5f);


                }

            }
        }
        if (touch.transform.gameObject.tag == "Cylinder4" && InAir.Instance.inAir == true && cylinderlist4.Count < 4)
        {
            temp.transform.DOLocalMove(new Vector3(obs4.position.x, obs4.position.y, obs4.position.z), 0.5f);
            if (temp.transform.position == new Vector3(obs4.position.x, obs4.position.y, obs4.position.z))
            {
                if (list == 1)
                {
                    cylinderlist.RemoveAt(cylinderlist.Count - 1);
                }
                else if (list == 2)
                {
                    cylinderlist1.RemoveAt(cylinderlist1.Count - 1);
                }
                else if (list == 3)
                {
                    cylinderlist2.RemoveAt(cylinderlist2.Count - 1);
                }
                else if (list == 4)
                {
                    cylinderlist3.RemoveAt(cylinderlist3.Count - 1);
                }
                else if (list == 5)
                {
                    cylinderlist4.RemoveAt(cylinderlist4.Count - 1);
                }
                else if (list == 6)
                {
                    cylinderlist5.RemoveAt(cylinderlist5.Count - 1);
                }
                if (cylinderlist4.Count == 0)
                {

                    cylinderlist4.Add(temp);
                    temp.transform.DOLocalMove(new Vector3(obs4.position.x, listOfPosition[0], obs4.position.z), 0.5f);


                }
                else if (cylinderlist4.Count == 1)
                {

                    cylinderlist4.Add(temp);
                    temp.transform.DOLocalMove(new Vector3(obs4.position.x, listOfPosition[1], obs4.position.z), 0.5f);


                }
                else if (cylinderlist4.Count == 2)
                {

                    cylinderlist4.Add(temp);
                    temp.transform.DOLocalMove(new Vector3(obs4.position.x, listOfPosition[2], obs4.position.z), 0.5f);


                }
                else if (cylinderlist4.Count == 3)
                {

                    cylinderlist4.Add(temp);
                    temp.transform.DOLocalMove(new Vector3(obs4.position.x, listOfPosition[3], obs4.position.z), 0.5f);


                }

            }
        }
        if (touch.transform.gameObject.tag == "Cylinder5" && InAir.Instance.inAir == true && cylinderlist5.Count < 4)
        {
            temp.transform.DOLocalMove(new Vector3(obs5.position.x, obs5.position.y, obs5.position.z), 0.5f);
            if (temp.transform.position == new Vector3(obs5.position.x, obs5.position.y, obs5.position.z))
            {
                if (list == 1)
                {
                    cylinderlist.RemoveAt(cylinderlist.Count - 1);
                }
                else if (list == 2)
                {
                    cylinderlist1.RemoveAt(cylinderlist1.Count - 1);
                }
                else if (list == 3)
                {
                    cylinderlist2.RemoveAt(cylinderlist2.Count - 1);
                }
                else if (list == 4)
                {
                    cylinderlist3.RemoveAt(cylinderlist3.Count - 1);
                }
                else if (list == 5)
                {
                    cylinderlist4.RemoveAt(cylinderlist4.Count - 1);
                }
                else if (list == 6)
                {
                    cylinderlist5.RemoveAt(cylinderlist5.Count - 1);
                }
                if (cylinderlist5.Count == 0)
                {

                    cylinderlist5.Add(temp);
                    temp.transform.DOLocalMove(new Vector3(obs5.position.x, listOfPosition[0], obs5.position.z), 0.5f);


                }
                else if (cylinderlist5.Count == 1)
                {

                    cylinderlist5.Add(temp);
                    temp.transform.DOLocalMove(new Vector3(obs5.position.x, listOfPosition[1], obs5.position.z), 0.5f);


                }
                else if (cylinderlist5.Count == 2)
                {

                    cylinderlist5.Add(temp);
                    temp.transform.DOLocalMove(new Vector3(obs5.position.x, listOfPosition[2], obs5.position.z), 0.5f);


                }
                else if (cylinderlist5.Count == 3)
                {

                    cylinderlist5.Add(temp);
                    temp.transform.DOLocalMove(new Vector3(obs5.position.x, listOfPosition[3], obs5.position.z), 0.5f);


                }

            }
        }
        }
        
    public void EndGame()
    {
        if (cylinderlist.Count != 0)
        {
            if (cylinderlist.Count == 4)
            {
                if (cylinderlist[0].tag.Equals(cylinderlist[1].tag) && cylinderlist[0].tag.Equals(cylinderlist[2].tag) && cylinderlist[0].tag.Equals(cylinderlist[3].tag))
                {
                    cylinderlistb = true;
                }
                else
                {
                    cylinderlistb = false;
                }
            }
        }
        if (cylinderlist1.Count != 0)
        {
            if (cylinderlist1.Count == 4)
            {
                if (cylinderlist1[0].tag.Equals(cylinderlist1[1].tag) && cylinderlist1[0].tag.Equals(cylinderlist1[2].tag) && cylinderlist1[0].tag.Equals(cylinderlist1[3].tag))
                {
                    cylinderlist1b = true;
                }
                else
                {
                    cylinderlist1b = false;
                }
            }
        }
        if (cylinderlist2.Count != 0)
        {
            if (cylinderlist2.Count == 4)
            {
                if (cylinderlist2[0].tag.Equals(cylinderlist2[1].tag) && cylinderlist2[0].tag.Equals(cylinderlist2[2].tag) && cylinderlist2[0].tag.Equals(cylinderlist2[3].tag))
                {
                    cylinderlist2b = true;
                }
                else
                {
                    cylinderlist2b = false;
                }
            }
        }
        if (PlayerPrefs.GetInt("level") > 2)
        {
            if (cylinderlist3.Count != 0)
            {
                if (cylinderlist3.Count == 4)
                {
                    if (cylinderlist3[0].tag.Equals(cylinderlist3[1].tag) && cylinderlist3[0].tag.Equals(cylinderlist3[2].tag) && cylinderlist3[0].tag.Equals(cylinderlist3[3].tag))
                    {
                        cylinderlist3b = true;
                    }
                    else
                    {
                        cylinderlist3b = false;
                    }
                }
            }
        }
        if (PlayerPrefs.GetInt("level") > 4)
        {
            if (cylinderlist4.Count != 0)
            {
                if (cylinderlist4.Count == 4)
                {
                    if (cylinderlist4[0].tag.Equals(cylinderlist4[1].tag) && cylinderlist4[0].tag.Equals(cylinderlist4[2].tag) && cylinderlist4[0].tag.Equals(cylinderlist4[3].tag))
                    {
                        cylinderlist4b = true;
                    }
                    else
                    {
                        cylinderlist4b = false;
                    }
                }
            }
        }
        if (PlayerPrefs.GetInt("level") > 7)
        {
            if (cylinderlist5.Count != 0)
            {
                if (cylinderlist5.Count == 4)
                {
                    if (cylinderlist5[0].tag.Equals(cylinderlist5[1].tag) && cylinderlist5[0].tag.Equals(cylinderlist5[2].tag) && cylinderlist5[0].tag.Equals(cylinderlist5[3].tag))
                    {
                        cylinderlist5b = true;
                    }
                    else
                    {
                        cylinderlist5b = false;
                    }
                }
            }
        }
    }
    public void AddBall()
    {
        for (int i = 1; i <= length; i++)
        {
            if (balllist.Count != 0)
            {
                if (PlayerPrefs.GetInt("level") == 1 || PlayerPrefs.GetInt("level") == 2)
                {
                    cylinderCount = UnityEngine.Random.Range(1, 4);
                }
                else if (PlayerPrefs.GetInt("level") == 3||PlayerPrefs.GetInt("level")==4)
                {
                    cylinderCount = UnityEngine.Random.Range(1, 5);
                }
                else if (PlayerPrefs.GetInt("level") == 5 || PlayerPrefs.GetInt("level") == 6 || PlayerPrefs.GetInt("level") == 7)
                {
                    cylinderCount = UnityEngine.Random.Range(1, 6);
                }
                else if (PlayerPrefs.GetInt("level") >7)
                {
                    cylinderCount = UnityEngine.Random.Range(1, 7);
                }
            
                if (cylinderCount == 1 && cylinderlist.Count < 4)
                {

                    if (cylinderlist.Count == 0)
                    {

                        Debug.Log("HAHAHAHAH");
                        Debug.Log(balllist.Count + "TOP SAYISI");
                        cylinderlist.Add(balllist[balllist.Count-1]);
                        cylinderlist[cylinderlist.Count - 1].transform.DOLocalMove(new Vector3(obs.position.x, listOfPosition[0], obs.position.z), 0.5f);
                        balllist.Remove(balllist[balllist.Count - 1]);
                        Debug.Log(cylinderlist.Count);
                    }
                    else if (cylinderlist.Count == 1)
                    {


                        Debug.Log("HAHAHAHAH");
                        cylinderlist.Add(balllist[balllist.Count - 1]);
                        cylinderlist[cylinderlist.Count - 1].transform.DOLocalMove(new Vector3(obs.position.x, listOfPosition[1], obs.position.z), 0.5f);
                        balllist.Remove(balllist[balllist.Count - 1]);
                        Debug.Log(cylinderlist.Count);
                    }
                    else if (cylinderlist.Count == 2)
                    {


                        Debug.Log("HAHAHAHAH");
                        cylinderlist.Add(balllist[balllist.Count - 1]);
                        cylinderlist[cylinderlist.Count - 1].transform.DOLocalMove(new Vector3(obs.position.x, listOfPosition[2], obs.position.z), 0.5f);
                        balllist.Remove(balllist[balllist.Count - 1]);
                        Debug.Log(cylinderlist.Count);
                    }
                    else if (cylinderlist.Count == 3)
                    {


                        Debug.Log("HAHAHAHAH");
                        Debug.Log(balllist.Count + "TOP SAYISI");
                        cylinderlist.Add(balllist[balllist.Count - 1]);
                        cylinderlist[cylinderlist.Count - 1].transform.DOLocalMove(new Vector3(obs.position.x, listOfPosition[3], obs.position.z), 0.5f);
                        balllist.Remove(balllist[balllist.Count - 1]);
                        Debug.Log(cylinderlist.Count);
                    }
                }

                
                if (cylinderCount == 2 && cylinderlist1.Count < 4)
                {
                    

                    if (cylinderlist1.Count == 0)
                    {
                     
                        Debug.Log("HAHAHAHAH");
                        Debug.Log(balllist.Count + "TOP SAYISI");
                        cylinderlist1.Add(balllist[balllist.Count - 1]);
                        cylinderlist1[cylinderlist1.Count - 1].transform.DOLocalMove(new Vector3(obs1.position.x, listOfPosition[0], obs1.position.z), 0.5f);
                        balllist.Remove(balllist[balllist.Count - 1]);
                        Debug.Log(cylinderlist1.Count);
                    }
                    else if (cylinderlist1.Count == 1)
                    {

                       
                        Debug.Log("HAHAHAHAH");
                        Debug.Log(balllist.Count + "TOP SAYISI");
                        cylinderlist1.Add(balllist[balllist.Count - 1]);
                        cylinderlist1[cylinderlist1.Count - 1].transform.DOLocalMove(new Vector3(obs1.position.x, listOfPosition[1], obs1.position.z), 0.5f);
                        balllist.Remove(balllist[balllist.Count - 1]);
                        Debug.Log(cylinderlist1.Count);
                    }
                    else if (cylinderlist1.Count == 2)
                    {

                      
                        Debug.Log("HAHAHAHAH");
                        Debug.Log(balllist.Count + "TOP SAYISI");
                        cylinderlist1.Add(balllist[balllist.Count - 1]);
                        cylinderlist1[cylinderlist1.Count - 1].transform.DOLocalMove(new Vector3(obs1.position.x, listOfPosition[2], obs1.position.z), 0.5f);
                        balllist.Remove(balllist[balllist.Count - 1]);
                        Debug.Log(cylinderlist1.Count);
                    }
                    else if (cylinderlist.Count == 3)
                    {

                       
                        Debug.Log("HAHAHAHAH");
                        Debug.Log(balllist.Count + "TOP SAYISI");
                        cylinderlist1.Add(balllist[balllist.Count - 1]);
                        cylinderlist1[cylinderlist1.Count - 1].transform.DOLocalMove(new Vector3(obs1.position.x, listOfPosition[3], obs1.position.z), 0.5f);
                        balllist.Remove(balllist[balllist.Count - 1]);
                        Debug.Log(cylinderlist1.Count);
                    }

                }
                if (cylinderCount == 3 && cylinderlist2.Count < 4 )
                {
                    

                    if (cylinderlist2.Count == 0)
                    {
                      
                        Debug.Log("HAHAHAHAH");
                        Debug.Log(balllist.Count + "TOP SAYISI");
                        cylinderlist2.Add(balllist[balllist.Count - 1]);
                        cylinderlist2[cylinderlist2.Count - 1].transform.DOLocalMove(new Vector3(obs2.position.x, listOfPosition[0], obs2.position.z), 0.5f);
                        balllist.Remove(balllist[balllist.Count - 1]);


                    }
                    else if (cylinderlist2.Count == 1)
                    {

                       
                        Debug.Log("HAHAHAHAH");
                        Debug.Log(balllist.Count + "TOP SAYISI");
                        cylinderlist2.Add(balllist[balllist.Count - 1]);
                        cylinderlist2[cylinderlist2.Count - 1].transform.DOLocalMove(new Vector3(obs2.position.x, listOfPosition[1], obs2.position.z), 0.5f);
                        balllist.Remove(balllist[balllist.Count - 1]);


                    }
                    else if (cylinderlist2.Count == 2)
                    {

                    
                        Debug.Log(balllist.Count + "TOP SAYISI");
                        Debug.Log("HAHAHAHAH");
                        cylinderlist2.Add(balllist[balllist.Count - 1]);
                        cylinderlist2[cylinderlist2.Count - 1].transform.DOLocalMove(new Vector3(obs2.position.x, listOfPosition[2], obs2.position.z), 0.5f);
                        balllist.Remove(balllist[balllist.Count - 1]);


                    }
                    else if (cylinderlist2.Count == 3)
                    {

                    
                        Debug.Log(balllist.Count + "TOP SAYISI");
                        Debug.Log("HAHAHAHAH");
                        cylinderlist2.Add(balllist[balllist.Count - 1]);
                        cylinderlist2[cylinderlist2.Count - 1].transform.DOLocalMove(new Vector3(obs2.position.x, listOfPosition[3], obs2.position.z), 0.5f);
                        balllist.Remove(balllist[balllist.Count - 1]);

                    }

                }
                if (cylinderCount == 4 && cylinderlist3.Count < 4)
                {
                   

                        if (cylinderlist3.Count == 0)
                        {

                            Debug.Log("HAHAHAHAH");
                            Debug.Log(balllist.Count + "TOP SAYISI");
                            cylinderlist3.Add(balllist[balllist.Count - 1]);
                            cylinderlist3[cylinderlist3.Count - 1].transform.DOLocalMove(new Vector3(obs3.position.x, listOfPosition[0], obs3.position.z), 0.5f);
                            balllist.Remove(balllist[balllist.Count - 1]);
                            Debug.Log(cylinderlist3.Count);
                        }
                        else if (cylinderlist3.Count == 1)
                        {


                            Debug.Log("HAHAHAHAH");
                            cylinderlist3.Add(balllist[balllist.Count - 1]);
                            cylinderlist3[cylinderlist3.Count - 1].transform.DOLocalMove(new Vector3(obs3.position.x, listOfPosition[1], obs3.position.z), 0.5f);
                            balllist.Remove(balllist[balllist.Count - 1]);
                            Debug.Log(cylinderlist.Count);
                        }
                        else if (cylinderlist3.Count == 2)
                        {


                            Debug.Log("HAHAHAHAH");
                            cylinderlist3.Add(balllist[balllist.Count - 1]);
                            cylinderlist3[cylinderlist3.Count - 1].transform.DOLocalMove(new Vector3(obs3.position.x, listOfPosition[2], obs3.position.z), 0.5f);
                            balllist.Remove(balllist[balllist.Count - 1]);
                            Debug.Log(cylinderlist.Count);
                        }
                        else if (cylinderlist3.Count == 3)
                        {


                            Debug.Log("HAHAHAHAH");
                            Debug.Log(balllist.Count + "TOP SAYISI");
                            cylinderlist3.Add(balllist[balllist.Count - 1]);
                            cylinderlist3[cylinderlist3.Count - 1].transform.DOLocalMove(new Vector3(obs3.position.x, listOfPosition[3], obs3.position.z), 0.5f);
                            balllist.Remove(balllist[balllist.Count - 1]);
                            Debug.Log(cylinderlist.Count);
                        }
                }
                if (cylinderCount == 5 && cylinderlist4.Count < 4)
                {

                    if (cylinderlist4.Count == 0)
                    {

                      
                        cylinderlist4.Add(balllist[balllist.Count - 1]);
                        cylinderlist4[cylinderlist4.Count - 1].transform.DOLocalMove(new Vector3(obs4.position.x, listOfPosition[0], obs4.position.z), 0.5f);
                        balllist.Remove(balllist[balllist.Count - 1]);
                       
                    }
                    else if (cylinderlist4.Count == 1)
                    {


                        
                        cylinderlist4.Add(balllist[balllist.Count - 1]);
                        cylinderlist4[cylinderlist4.Count - 1].transform.DOLocalMove(new Vector3(obs4.position.x, listOfPosition[1], obs4.position.z), 0.5f);
                        balllist.Remove(balllist[balllist.Count - 1]);
                   
                    }
                    else if (cylinderlist4.Count == 2)
                    {


                  
                        cylinderlist4.Add(balllist[balllist.Count - 1]);
                        cylinderlist4[cylinderlist4.Count - 1].transform.DOLocalMove(new Vector3(obs4.position.x, listOfPosition[2], obs4.position.z), 0.5f);
                        balllist.Remove(balllist[balllist.Count - 1]);
                      
                    }
                    else if (cylinderlist4.Count == 3)
                    {


                     
             
                        cylinderlist4.Add(balllist[balllist.Count - 1]);
                        cylinderlist4[cylinderlist4.Count - 1].transform.DOLocalMove(new Vector3(obs4.position.x, listOfPosition[3], obs4.position.z), 0.5f);
                        balllist.Remove(balllist[balllist.Count - 1]);
                     
                    }
                }
                if (cylinderCount == 6 && cylinderlist5.Count < 4)
                {

                    if (cylinderlist5.Count == 0)
                    {

                     
                        cylinderlist5.Add(balllist[balllist.Count - 1]);
                        cylinderlist5[cylinderlist5.Count - 1].transform.DOLocalMove(new Vector3(obs5.position.x, listOfPosition[0], obs5.position.z), 0.5f);
                        balllist.Remove(balllist[balllist.Count - 1]);
                       
                    }
                    else if (cylinderlist5.Count == 1)
                    {


                      
                        cylinderlist5.Add(balllist[balllist.Count - 1]);
                        cylinderlist5[cylinderlist5.Count - 1].transform.DOLocalMove(new Vector3(obs5.position.x, listOfPosition[1], obs5.position.z), 0.5f);
                        balllist.Remove(balllist[balllist.Count - 1]);
                        
                    }
                    else if (cylinderlist5.Count == 2)
                    {


                       
                        cylinderlist5.Add(balllist[balllist.Count - 1]);
                        cylinderlist5[cylinderlist5.Count - 1].transform.DOLocalMove(new Vector3(obs5.position.x, listOfPosition[2], obs5.position.z), 0.5f);
                        balllist.Remove(balllist[balllist.Count - 1]);
                      
                    }
                    else if (cylinderlist5.Count == 3)
                    {


                    
                   
                        cylinderlist5.Add(balllist[balllist.Count - 1]);
                        cylinderlist5[cylinderlist5.Count - 1].transform.DOLocalMove(new Vector3(obs5.position.x, listOfPosition[3], obs5.position.z), 0.5f);
                        balllist.Remove(balllist[balllist.Count - 1]);
                       
                    }
                }


            }
        }
        } 
    }
