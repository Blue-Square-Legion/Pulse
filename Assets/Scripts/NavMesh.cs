using System.Collections;
using System.Collections.Generic;
using UnityEditor.Search;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SocialPlatforms.Impl;

public class NavMesh : MonoBehaviour
{
    public List<GameObject> productionQueue = new List<GameObject>();
   // public Transform target;
    
    private NavMeshAgent agent;
   // [SerializeField] Transform[] waypoints;
  //  [SerializeField] private int destinationPoint;
  //  public GameObject stop1;
  // public GameObject stop2;
    bool _continue=true;
    int i =0;
    public GameObject Leadcar;
    private float timer = 12f;
    
    bool _proceed=false;
   public float distance;
    public void Start()
    {
         i=0;
      //  wayPt[0].SetActive(true);
     //   wayPt[1].SetActive(false);
      //  wayPt[2].SetActive(false);
     //   wayPt[3].SetActive(false);
        // stop1.SetActive(true);
        // stop2.SetActive(false);
        agent = GetComponent<NavMeshAgent>();
        agent.GetComponent<NavMeshAgent>().speed = 35f;
    }
    
public void GoToNext()
{
foreach (GameObject wpt in productionQueue)
{
distance = Vector3.Distance(wpt.transform.position,Leadcar.transform.position);               
if(distance <= 50)
{  
     Destroy(wpt);

}

 wpt.SetActive(true);
agent.SetDestination(wpt.transform.position);
}       
}

 
    public void Update()
    {
     
          GoToNext();
      
    }
}