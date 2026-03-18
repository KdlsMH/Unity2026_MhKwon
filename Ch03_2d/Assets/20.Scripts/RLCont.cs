using UnityEngine;
using UnityEngine.InputSystem; // 새로운 Input System을 사용하기 위해 반드시 추가해야 합니다.

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
        if (Mouse.current != null && Mouse.current.leftButton.isPressed)
        {
            this.rotSpeed = 10f;
        }

        // 참고: 현재 코드로는 한 번 클릭하면 rotSpeed가 계속 10f로 유지되어 영원히 돌아갑니다.
        // 마우스를 떼었을 때 멈추게 하려면 아래 주석을 해제하세요.
        /*
        else
        {
            this.rotSpeed = 0f;
        }
        */

        transform.Rotate(0, 0, rotSpeed);
    }
}