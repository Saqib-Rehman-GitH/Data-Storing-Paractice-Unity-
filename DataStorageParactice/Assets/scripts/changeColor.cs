using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColor : MonoBehaviour
{

    //[ContextMenu("Save Data")]

    public bool isRed { get; set; }


    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitInfo;
            if (GetComponent<Collider>().Raycast(ray, out hitInfo, Mathf.Infinity))
            {
                isRed = !isRed;
                changeCubeColor();
                
            }
        }
    }


    private void changeCubeColor()
    {
        GetComponent<MeshRenderer>().material.color = isRed ? Color.red : Color.green;
    }

}
