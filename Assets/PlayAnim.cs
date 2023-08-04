using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayAnim : MonoBehaviour
{
    [SerializeField] public Animator CardAnimAnimator;
    [SerializeField] public TextMeshProUGUI FPSCOunter;
    private float tickInterval = 100f;

    private float ticks = 0f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ticks++;
        if (ticks >= tickInterval)
        {
            float fps = 1.0f / Time.deltaTime;
            if (fps > 60f)
            {
                //fps = 60f;
            }
            FPSCOunter.text = "FPS: " + fps.ToString("F0");
            ticks = 0;
        }

       
    }

    public void PlayAnimation(string name) 
    {
        
        CardAnimAnimator.Play(name);
        
    }




}
