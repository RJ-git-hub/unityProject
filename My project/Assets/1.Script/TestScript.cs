using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestScript : MonoBehaviour
{
    [SerializeField] private int myGold;
    public int potion;
    public int count;
    public int S_char;
    public int A_char;
    public int B_char;
    public int C_char;
    public int special;
    public int redPotion;
    public int yellowPotion;
    public int bluePotion;
    [SerializeField] string pickup = "";

    // Start is called before the first frame update
    void Start()
    {
        switch(pickup)
        {
            case "일등감자":
                gatcha(pickup);
                break;

            case "이등감자":
                gatcha(pickup);
                break;

            default:
                break;
        }
                
        
        /*string wish = "노란 포션";       // 내가 원하는 포션

        switch (wish)                   // 선택한 포션
        {
            case "빨간 포션":            // 빨간 포션 상황
                myGold -= 200;          // 200 골드를 지불합니다.    
                redPotion++;            // 빨간 포션을 구매합니다.
                break;                  // switch 문을 종료합니다.

            case "노란 포션":            // 노란 포션 상황
                myGold -= 150;          // 150 골드를 지불합니다.    
                yellowPotion++;         // 노란 포션을 구매합니다.
                break;                  // switch 문을 종료합니다.

            case "파란 포션":            // 파란 포션 상황
                myGold -= 300;          // 300 골드를 지불합니다.    
                bluePotion++;           // 파란 포션을 구매합니다.
                break;                  // switch 문을 종료합니다.

            default:                    // 어떠한 상황도 맞지 않을 때, 동작하는 기본값입니다.
                break;
        }

        Debug.Log($"남은 골드 : {myGold} / R : {redPotion} / Y : {yellowPotion} / B : {bluePotion}");
        */

        /*if (200 <= mygold)
        {
            mygold -= 200;
            potion++;
        }
        else if (100 <= mygold)
        {
            mygold -= 100;
            potion++;
        }

        else
        {
            angry();
        }
            
        Debug.Log("내 보유 골드 : " + mygold);
        Debug.Log("내 보유 포션 : " + potion);*/
    }

    void gatcha(string pick)
    {
        for (int i = 0; i < count; i++)
        {
            int gatcha = random();
            if (gatcha <= 5)
            {
                special= Random.Range(0, 2);
                if(special == 0)
                {
                    Debug.Log("픽업 "+ pick +" S 등급 상품 " + gatcha);
                }
                else
                {
                    Debug.Log("S 등급 상품 " + gatcha);
                }
            }
            else if (gatcha <= 20)
            {
                Debug.Log("A 등급 상품 " + gatcha);
            }
            else if (gatcha <= 50)
            {
                Debug.Log("B 등급 상품 " + gatcha);
            }
            else
            {
                Debug.Log("C 등급 상품 " + gatcha);
            }
        }
    }
    void angry()
    {
        Debug.Log("상점 주인이 당신을 발로 차 상점 밖으로 내쫓았습니다.");
    }

    int random()
    {
        return Random.Range(0, 101);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
