using UnityEngine;


public class BackGroundLoop : MonoBehaviour
{
    private float width; //��氡�α���
    private void Awake()
    {
        // ���� ���̸� �����ϴ� ó
        //BoxCollider2D �� Size �ʵ��� x ���� ���� ���̷� ���
        BoxCollider2D backgroundCollider = GetComponent<BoxCollider2D>();
        width = backgroundCollider.size.x;
    }
    private void Update()
    {
        //���� ��ġ�� �������� �������� width �̻� �̵������� ��ġ�� ���ġ
        if (transform.position.x <= -width)
        {
            Repostion();
        }

    }

    private void Repostion()
    { //���� ��ġ���� ���������� ���� ���� * 2��ŭ �̵�
        Vector2 offset = new Vector2(width * 2f, 0);
        transform.position= (Vector2) transform.position + offset;
    }
  
   
}
