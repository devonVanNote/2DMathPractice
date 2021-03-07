using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManager : MonoBehaviour
{
    public GameObject objectPrefab;
    public Vector3 objectPosition;
    // Start is called before the first frame update
    void Awake()
    {
        Vector3 randomPosition = new Vector3(Random.Range(-100, 100), Random.Range(-100, 100), objectPrefab.transform.position.z);
        GameObject gameObject = Instantiate(objectPrefab, randomPosition, Quaternion.identity);
        objectPosition = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
