using System.Threading;
using Unity.VisualScripting;
using UnityEngine;


public class RLCont : MonoBehaviour
{
    float rotSpeed = 0;

    void Start()
    {
        Application.targetFrameRate = 30;
    }

    void Update()
    {
        // 새로운 Input System의 마우스 좌클릭 감지 방식
        if (Input.GetMouseButton(0))
        {
            this.rotSpeed = 10;
        }
    transeform.Rotate(0,0,this.rotSpeed);
    this.rotSpeed *= 0.3;
    }
    
}