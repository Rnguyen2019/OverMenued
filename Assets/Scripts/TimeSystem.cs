using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeSystem : MonoBehaviour
{
    public Text timeText;
    public static float timer = 60;
    private float lowTime = timer / 3;
    private float rotator = 0;
    private float rotatorChange = 0.01f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Bounce();
        UpdateText();
        LowTime();

        if(Input.GetKeyDown(KeyCode.P)){
            //CompleteDish();
        }
    }
    public void Bounce(){
        rotator += rotatorChange;
        gameObject.transform.eulerAngles = new Vector3(transform.eulerAngles.x, transform.eulerAngles.y, rotator);
        if (rotator >= 10 || rotator <= -10){
            rotatorChange *= -1;
        }
    }
    public void UpdateText(){
         timer -= Time.deltaTime;
        if (timer <= 0){
            timeText.text = "Out of Time!";
            //timeText.text = "Fucking Loser Moron Idiot Shit Head Nerd!";
        }
        else{
            if(timer.ToString().Length >= 5){
                timeText.text = "" + timer.ToString().Substring(0,5);
            }
        }
    }
    public void LowTime(){
        Color dsgw = new Color(190, 50, 30);
        if (timer <= lowTime){
            timeText.GetComponent<Text>().color = Color.red;
        }
        else{
            timeText.GetComponent<Text>().color = Color.white;
        }
    }
    public void CompleteDish(){
        timer += 60;
    }
}
