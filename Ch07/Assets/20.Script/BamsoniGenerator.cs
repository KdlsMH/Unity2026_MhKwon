using UnityEngine;

public class BamsoniGenerator : MonoBehaviour
{
    public GameObject bamsongiPrefab;
    public float throwForce = 10f;
    public float minPower = 10f;

    float startY;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startY = Input.mousePosition.y;
        }

        if (Input.GetMouseButtonUp(0))
        {
            float power = Input.mousePosition.y - startY;
            if (power < minPower) return;

            GameObject bamsongi = Instantiate(bamsongiPrefab);
            bamsongi.transform.position = transform.position;
            

            //Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            Vector3 dir = transform.forward + transform.up * 0.5f;

            bamsongi.GetComponent<BamsongiController>().Shoot(dir);
        }
    }
}

