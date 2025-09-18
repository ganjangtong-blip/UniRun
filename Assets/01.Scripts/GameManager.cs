using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class GameManager : MonoBehaviour
{
    public static GameManager instance; //�̤������� �Ҵ��� ���� ����

    public bool isGameover = false; //���ӿ��� ����
    public TextMeshProUGUI scoreText; // ������ ����� ui �ؽ�Ʈ
    public GameObject gameoverUI; // ���ӿ����� Ȱ��ȭ�� ui ���� ������Ʈ 

    private int score = 0;  // ���� ����

    // ���� ���۰� ���ÿ� �̱����� ����
    private void Awake()
    {
         //�̱��� ���� instanxe �� ����ִ°�?

        if (instance == null)
        {
            //instance�� ����ִٸ� (null) �װ��� �ڱ� �ڽ��� �Ҵ�
            instance = this;
        }
        else
        {
            // instance�� �̹� �ٸ� gamemanager ������Ʈ�� �Ҵ�Ǿ� �ִ� ���
            // ���� �ΰ� �̻��� gamemanager ������Ʈ�� �����Ѵٴ� �ǹ�
            // �̱��Ϥ� ������Ʈ�� �ϳ��� �����ؾ� �ϹǷ� �ڽ��� ���� ������Ʈ�� �ı�
            Debug.LogWarning("���� �� �� �̻��� ���� �Ŵ����� �����մϴ�!");
            Destroy(gameObject);
        }
    }



    void Update()
    {
        //���ӿ��� ���¿��� ������ ������Ҽ��ְ� �ϴ� ó��
        if (isGameover && Input.GetMouseButtonDown(0)) 
        {
            //���ӿ��� ���¿��� ���콺 ���ʹ�ư�� Ŭ���ϸ� ���� �� �����
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }

    //������ ������Ű�� �޼���
    public void AddScore(int newScore)
    {
        // ���ӿ����� �ƴ϶��
        if (!isGameover)
        {
            //������ ����
            score += newScore;
            scoreText.text = "Score : " + score;
        }

    }
    //�÷��̾� ĳ���� ����� ���ӿ����������ϴ� �޼���
    public void OnPlayerDead()
    {
        isGameover = true;
        gameoverUI.SetActive(true);
    }
}
