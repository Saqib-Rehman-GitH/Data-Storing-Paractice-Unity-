using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeInitializer : MonoBehaviour
{
   public GameObject cube;

   public int quantity = 5;

   public float xPos = 0;

   void Start()
   {
      cubeCreation();
      Debug.Log("All Cubes Initiated");
      Debug.Log("Time Taken "+Time.realtimeSinceStartup);
      
      
   }

   #region cubeInitiation
   void cubeCreation()
   {

      for (int i = 0 ; i <= quantity  ; i++)
      {
         Vector3 pos =  new Vector3( xPos , 0 , 0 );
         GameObject clone = Instantiate(cube, pos, Quaternion.identity);
         xPos = cube.transform.localScale.x * i;
         Debug.Log($"xScale postion of iteratin no ... {i} is .... {xPos}/n");
      }
   }

   #endregion


}
