using UnityEngine;
//게임 오브젝트를 꼐속 왼쪽으로 움직이는 스크립트 
public class ScrollingObject : MonoBehaviour
{

    public float speed = 10f; //이동속도
    private void Update()
    {
        // 게임오버가 아니라면
        if (!GameManager.instance.isGameover)
        {

            //초당 SPEED의 속도로 왼쪽으로 평행이동
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

    }
    
}
