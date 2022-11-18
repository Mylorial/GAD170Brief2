using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishStats : MonoBehaviour
{
           public List<string> collectionOfNames;
    public List<string> collectionOfLength;
    public List<string> collectOfValues;
    


    public string conName;
    public string conLength;
    public string conValues;
    // Start is called before the first frame update
      public void Fish()
    {

            int randomName = Random.Range(0,(collectionOfNames.Count));
            int Length = Random.Range(0,(collectionOfLength.Count));
            int Values = Random.Range(0,(collectOfValues.Count));
           
            conName = collectionOfNames[randomName];
           conLength = collectionOfLength[Length];
         conValues = collectOfValues[Values]; 

         print("Player has caught a " + conName + ". it's roughly "+conLength+"m long and has a value of " + conValues);

    }

    public void releaseFish()
    {

    }


    void Start()
    {
    
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
