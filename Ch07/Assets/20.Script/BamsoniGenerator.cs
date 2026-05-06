using UnityEngine;

public class BamsoniGenerator : MonoBehaviour
{
    public GameObject bamsongiPrefab;
    public float throwForce = 10f;

    float startY;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            startY = Input.mousePosition.y;
        }

        if (Input.GetMouseButtonUp(0))
        {
            GameObject bamsongi = Instantiate(bamsongiPrefab);
            bamsongi.transform.position = transform.position;

            float power = Input.mousePosition.y - startY;

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            Vector3 dir = ray.direction * power * throwForce;

            bamsongi.GetComponent<BamsongiController>().Shoot(dir);
        }
    }
}

