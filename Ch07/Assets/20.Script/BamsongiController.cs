using UnityEngine;

public class BamsongiController : MonoBehaviour
{
    public MeshRenderer renderer;
    void Start()
    {
        Application.targetFrameRate = 60;
        //Shoot(new Vector3(0, 200, 2000));
    }

    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce (dir);
    }
    private void OnCollisionEnter(Collision collision)
    {
         ////renderer.enab
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<ParticleSystem>().Play();
        Destroy(gameObject, 0.5f);

    }
}
