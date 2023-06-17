using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UIを使うときに書きます。

public class HpBar : MonoBehaviour
{
    //最大HPと現在のHP。
    int maxHp = 10;
    int Hp;
    //Slider
    public Slider slider;

    void Start()
    {
        //Sliderを最大にする。
        slider.value = 1;
        //HPを最大HPと同じ値に。
        Hp = maxHp;
    }

    private void OnTriggerEnter(Collider collider)
    {
        //Enemyタグを設定しているオブジェクトに接触したとき
        if (collider.gameObject.tag == "Enemy")
        {
            //HPから1を引く
            Hp = Hp - 1;//Hp--

            //HPをSliderに反映。
            slider.value = (float)Hp / (float)maxHp;

        }
        if (slider.value <= 0)
        {
            Destroy(this.gameObject);
                }
        
  
    }
}