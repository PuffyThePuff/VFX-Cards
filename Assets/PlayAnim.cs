using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayAnim : MonoBehaviour
{
    [SerializeField] public Animator CardAnimAnimator;
    [SerializeField] public Text FPSCOunter;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FPSCOunter.text = (1.0f/Time.deltaTime).ToString();
    }

    public void PlayAnimation(string name) 
    {
        
        CardAnimAnimator.Play(name);
        
    }




}
