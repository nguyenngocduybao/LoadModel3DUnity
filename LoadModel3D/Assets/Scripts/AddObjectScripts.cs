using System;
using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.UI;

#if UNITY_EDITOR
public class AddObjectScripts : MonoBehaviour
{    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform != null)
                {
                    GameObject obj = hit.transform.gameObject;
                    
                    AddScript(hit.transform.gameObject, "ObjectRotation");                           
                }
            }
        }
    }

    void AddScript(GameObject obj, string script)
    {
        //if (obj.tag == "GameObject")
        //{
            if ( obj.GetComponent(script) == null)
            {
                obj.AddComponent(Type.GetType(script));
            }
            else if (obj.GetComponent(script) != null)
            {
            //var temp = obj.GetComponent(script);
            //Destroy(temp);
            return;
            }
        //}
    }
}
#endif