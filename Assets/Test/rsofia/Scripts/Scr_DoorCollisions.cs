﻿//ruth sofia brown
//git rsofia
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scr_DoorCollisions : MonoBehaviour
{
    GameObject parent;

    private void Awake()
    {
        parent = transform.parent.gameObject;
        //print(parent.name);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag != "DoorFrame" && other.gameObject != parent)
        {
            //if(other.gameObject.GetComponent<Renderer>() != null)
            //    other.gameObject.GetComponent<Renderer>().material.color = Color.red;
            //else
            //    other.gameObject.GetComponentInChildren<Renderer>().material.color = Color.red;
            
            //rotar - 90
            if (!parent.GetComponent<N_Modules>().isCorner)
            {
                if (parent.GetComponent<N_Modules>().timesSpinned < 4)
                {
                    if (parent.GetComponent<N_Modules>().gridLayout[0].rowdata.Length > 1)
                    {
                        //parent.transform.Rotate(0.0f, 0.0f, 180.0f);
                        if(parent.GetComponent<N_Modules>().id == 2)
                        {
                            Transform child = parent.transform.Find(parent.name);
                            if (child != null)
                            {
                                child.Rotate(0.0f, 0.0f, 180.0f);
                            }
                        }  
                        else if(parent.GetComponent<N_Modules>().id == 4)
                        {
                            Transform child = parent.transform.Find(parent.name);
                            if (child != null)
                            {
                                child.Rotate(0.0f, 0.0f, 90.0f);
                            }
                        }
                    }
                    else
                        parent.transform.Rotate(new Vector3(0.0f, 0.0f, -90.0f));
                    parent.GetComponent<N_Modules>().timesSpinned++;
                    //parent.GetComponentInChildren<Renderer>().material.color = Color.blue;
                }
                else
                    parent.GetComponentInChildren<Renderer>().material.color = Color.cyan;
            }

                
        }
            
    }

    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.tag != "DoorFrame" && other.gameObject != parent)
    //    {
    //        if (other.gameObject.GetComponent<Renderer>() != null)
    //            other.gameObject.GetComponent<Renderer>().material.color = Color.green;
    //        else
    //            other.gameObject.GetComponentInChildren<Renderer>().material.color = Color.green;
    //    }
    //}

}
