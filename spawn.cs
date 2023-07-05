using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour
{
    public Transform objectToSpawn;
    // Start is called before the first frame update

    void Start()
    {
        StartCoroutine(objTimer());
       
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator objTimer()
    {
        yield return new WaitForSeconds(3);
        Instantiate(objectToSpawn, transform.position, transform.rotation);
        StartCoroutine(objTimer());
    }
}
