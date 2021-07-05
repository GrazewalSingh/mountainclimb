using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class introwait : MonoBehaviour
{
   [SerializeField] float wait_time = 5f;
  
    void Start()
    {
        StartCoroutine(waitforintro());
    }
    IEnumerator waitforintro()
    {
        yield return new WaitForSeconds(wait_time);
        SceneManager.LoadScene(1);
    }
    
    
}
