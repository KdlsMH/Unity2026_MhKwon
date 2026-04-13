using UnityEngine;

public class ArrowGenerator : MonoBehaviour
{
    public GameObject arrowPrefab;
    float span = 1.0f;
    float delta = 0;

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if(delta > span)
        {
            delta = 0;
            GameObject go = Instantiate(arrowPrefab);
            float px = Random.Range(-8f, 8f);
            go.transform.position = new Vector3(px, 6f, 0);
        }
    }
}
