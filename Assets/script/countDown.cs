using UnityEngine;
using UnityEngine.UI;

public class countDown : MonoBehaviour
{
    public Text timeText;
    float time = 90;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (timeText == null)
        {
            timeText = GetComponent<Text>();
        }
    }

    // Update is called once per frame
    void Update()
    {

        
        time -= Time.deltaTime;
        timeText.text = time.ToString();
        Debug.Log("time: " + time);
        if (time <= 0)
        {
            timeText.text = "You lost";
        } 
    }
}
