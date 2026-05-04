using Tanks.Complete;
using UnityEngine;

public class BamsoniGenerator : MonoBehaviour
{
    public GameObject bamsongiPrefabs;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (TankInputUser.GetMouseButtonDown(0))
        {
            GameObject bamsongi = instantitate(bamsongiPrefabs);
            bamsongi.transform.position = transform.position;
            //Vector3 dir = new Vector3(0, 200, 2000);
            //bamsongi.GetComponent<BamsongiController>().Shoot(dir);
        }
    }
}
