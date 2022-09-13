using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TankHealth : MonoBehaviour
{
    public GameObject tankExplosion;
    public float hp = 100;
    public Slider slider;
    public GM gm;
    private float totalHp;
    // Start is called before the first frame update
    void Start()
    {
        totalHp = hp;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void triggerTank1()
    {
        if(this.tag != "Tank1")
        {
            return;
        }
        triggerTank();
    }

    private void triggerTank2()
    {
        if(this.tag != "Tank2")
        {
            return;
        }
        triggerTank();
    }

    private void triggerTank()
    {
        Debug.Log(this.tag);
        if (hp <= 0)
        {
            return;
        }

        hp -= Random.Range(10, 20);
        slider.value = hp / totalHp;
        Debug.Log(slider.value);
        if (hp <= 0)
        {
            //GM gm = new GM();
 
            GameObject.Instantiate(tankExplosion, transform.position + transform.up, transform.rotation);
            GameObject.Destroy(this.gameObject);
            if (this.tag == "Tank1")
            {
                gm.stopGameWithPlayer2();
            }
            else if (tag == "Tank2")
            {
                gm.stopGameWithPlayer1();
            }

        }
    }
}
