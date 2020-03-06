using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;//CONVERTS OUR DATA AT RUNTIME TO BINARY FORMAT 
using System.IO;//fOR SIMPLE INPUT AND OUTPUT OPERATIONS.....




[System.Serializable]
public class binarySerialization 
{
   
   //STEPS
   //01-GIVE A PATH TO SOME VARIABLE 
   //02-OPEN A BINAR FLE PORTAL .
   //03-SAVE BINARY FILE TO THE PC .
   void saveData()
   {
      //SPECIFYING PATH ;
      
      BinaryFormatter bf =  new BinaryFormatter();
      FileStream file = new FileStream(Application.persistentDataPath + "/player.sav", FileMode.Create);
      
      data localData = new data();
      bf.Serialize(file,localData);
      
         
      
   }



}


public class data
{
   public int[] dataSet;

   public data()
   {
      
      dataSet = new int[3];
      dataSet[0] = 1;
      dataSet[1] = 2;
      dataSet[2] = 3;

   }



} 
