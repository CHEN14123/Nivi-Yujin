using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerReset : MonoBehaviour
{
    //public GameObject Target1;    
    //private GameObject Obstacle;
    public GameObject[] Targets;
    private int i;
    public GameObject Player;

    private void Start()
    {
        FindTarget();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Obstacle")
        {                        
           Reset();
        }
    }   
    private void FindTarget()
    {       
        i = Random.Range(0, Targets.Length);
        Targets = GameObject.FindGameObjectsWithTag("Targets");
        Debug.Log("Error"+Targets);
        Player.transform.position = Targets[i].transform.position;
    }
        
    private void Reset()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name, LoadSceneMode.Single);       
    }
}
