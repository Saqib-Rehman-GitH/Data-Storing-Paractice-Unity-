using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class jsonConnector : MonoBehaviour
{
    //Sudo Code 
    //(01)--> we built a class below to directly map our json to .
    //(02)-->now  first we specify the path where our json file is stored.

    public string localPath;
    public string dataExtractedFromJsonFile;

    void Start()
    {
        localPath = Application.json + "/data.json";
        dataExtractedFromJsonFile = File.ReadAllText(localPath);
     jsonObject playerData = JsonUtility.FromJson<jsonObject>(localPath);

     
        
    }




}


[System.Serializable]
public class jsonObject
{
    public  string Name;
    public int level;
    public int[] stats;


}
    
