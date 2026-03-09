using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMy : MonoBehaviour
{
    private string name = "정재훈";
    private int age = 0;
    private double height = 177.7;
    private string MBTI = "ISFP";
    private string hobby = "음악감상";
    private int footSize = 280;
    private string game = "포켓몬스터";
    private string zodiac = "천칭차리";
    private string bloodType = "A";
    private string animal = "개";
    // Start is called before the first frame update
    void Start()
    {
        selfIntroduce();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void selfIntroduce()
    {
        Debug.Log("제 이름은 " + name + "입니다.");
        Debug.Log("제 나이는 " + age + "입니다.");
        Debug.Log("제 키는 " + height + "cm 입니다.");
        Debug.Log("제 MBTI는 " + MBTI + "입니다.");
        Debug.Log("제 취미는 " + hobby + "입니다.");
        Debug.Log("제 발크기는 " + footSize + "mm 입니다.");
        Debug.Log("제가 좋아하는 게임은 " + game + "입니다.");
        Debug.Log("제 별자리는 " + zodiac + "입니다.");
        Debug.Log("제 혈액형은 " + bloodType + "입니다.");
        Debug.Log("저는 " + animal + "띠 입니다.");
    }
}
