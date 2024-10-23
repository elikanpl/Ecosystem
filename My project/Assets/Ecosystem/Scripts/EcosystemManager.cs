using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EcosystemManager : MonoBehaviour
{
    private int noOfLeopards;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void checkLeopardNo()
    {
        JudgementalLeopard[] judgementalLeopards = FindObjectsOfType<JudgementalLeopard>();
        for (int i = 0; i < judgementalLeopards.Length; i++)
        {

        }
    }

    private void updateLeopardNo()
    {

    }
}
