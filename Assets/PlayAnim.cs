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

    [SerializeField] public List<GameObject> firelist;
    [SerializeField] public List<GameObject> waterlist;
    [SerializeField] public List<GameObject> lightninglist;

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

    public void ActiveParticle(int num)
    {
        setallInactive();
        switch (num)
        {
            case 1:
                foreach (var go in firelist)
                {
                    go.SetActive(true);
                }
                break;
            case 2:
                foreach (var go in waterlist)
                {
                    go.SetActive(true);
                }
                break;
            case 3:
                foreach (var go in lightninglist)
                {
                    go.SetActive(true);
                }
                break;
            default:
                break;
        }

    }


    private void setallInactive()
    {
        foreach (var go in firelist)
        {
            go.SetActive(false);
        }
        
        foreach (var go in waterlist)
        {
            go.SetActive(false);
        }
       
        foreach (var go in lightninglist)
        {
            go.SetActive(false);
        }
    }
}
