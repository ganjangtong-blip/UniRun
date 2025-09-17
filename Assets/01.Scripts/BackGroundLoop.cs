using UnityEngine;


public class BackGroundLoop : MonoBehaviour
{
    private float width; //배경가로길이
    private void Awake()
    {
        // 가로 길이를 측정하는 처
        //BoxCollider2D 의 Size 필드의 x 값을 가로 길이로 사용
        BoxCollider2D backgroundCollider = GetComponent<BoxCollider2D>();
        width = backgroundCollider.size.x;
    }
    private void Update()
    {
        //현재 위치가 원점에서 왼쪽으로 width 이상 이동했을때 위치를 재배치
        if (transform.position.x <= -width)
        {
            Repostion();
        }

    }

    private void Repostion()
    { //현재 위치에서 오른쪽으로 가로 길이 * 2만큼 이동
        Vector2 offset = new Vector2(width * 2f, 0);
        transform.position= (Vector2) transform.position + offset;
    }
  
   
}
