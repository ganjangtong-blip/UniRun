using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class GameManager : MonoBehaviour
{
    public static GameManager instance; //싱ㅋ글턴을 할당할 전역 변수

    public bool isGameover = false; //게임오버 상태
    public TextMeshProUGUI scoreText; // 점수를 출력할 ui 텍스트
    public GameObject gameoverUI; // 게임오버시 활성화할 ui 게임 오브젝트 

    private int score = 0;  // 게임 점수

    // 게임 시작과 동시에 싱글턴을 구성
    private void Awake()
    {
         //싱글턴 변수 instanxe 가 비어있는가?

        if (instance == null)
        {
            //instance가 비어있다면 (null) 그곳에 자기 자신을 할당
            instance = this;
        }
        else
        {
            // instance에 이미 다른 gamemanager 오브젝트가 할당되어 있는 경우
            // 씬에 두개 이상의 gamemanager 오브젝트가 존재한다는 의미
            // 싱글턴ㅇ 오브젝트는 하나만 존재해야 하므로 자신의 게임 오브젝트를 파괴
            Debug.LogWarning("씬에 두 개 이상의 게임 매니저가 조재합니다!");
            Destroy(gameObject);
        }
    }



    void Update()
    {
        //게임오버 상태에서 게임을 재시작할수있게 하는 처리
        if (isGameover && Input.GetMouseButtonDown(0)) 
        {
            //게임오버 상태에서 마우스 왼쪽버튼을 클릭하면 현재 씬 재시작
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }

    //점수를 증가시키는 메서드
    public void AddScore(int newScore)
    {
        // 게임오버가 아니라면
        if (!isGameover)
        {
            //점수를 증가
            score += newScore;
            scoreText.text = "Score : " + score;
        }

    }
    //플레이어 캐릭터 사망시 게임오버를실행하는 메서드
    public void OnPlayerDead()
    {
        isGameover = true;
        gameoverUI.SetActive(true);
    }
}
