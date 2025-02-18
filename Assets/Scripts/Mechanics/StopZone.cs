using UnityEngine;

public class StopZone : MonoBehaviour
{
    private bool playerHasStopped = false;
    private bool playerHasEnteredZone = false;

    //AI - Determine their behaviour
    public NavMesh[] navMeshScripts;

    void Update()
    {
        navMeshScripts = FindObjectsOfType<NavMesh>();

        if ( !playerHasEnteredZone ) return;

        if (CarController.speed <= .5 ) playerHasStopped = true;
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            playerHasStopped = false;
            playerHasEnteredZone = true;
        }
    }

    void OnTriggerExit(Collider collider)
    {
        if (!playerHasStopped) LevelManager.instance.StopZoneViolation();
    }


}