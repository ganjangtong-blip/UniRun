using UnityEngine;
//���� ������Ʈ�� ���� �������� �����̴� ��ũ��Ʈ 
public class ScrollingObject : MonoBehaviour
{

    public float speed = 10f; //�̵��ӵ�
    private void Update()
    {
        // ���ӿ����� �ƴ϶��
        if (!GameManager.instance.isGameover)
        {

            //�ʴ� SPEED�� �ӵ��� �������� �����̵�
            transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

    }
    
}
