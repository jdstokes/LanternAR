using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstructorController : MonoBehaviour
{
    public GameObject menuCanvas;
    public List<GameObject> steps;
    public int currentStep = 0;

    private void Start()
    {
        steps[currentStep].SetActive(true);

        for(int i = 0; i < steps.Count; i++)
        {
            if (i != currentStep)
            {
                steps[i].SetActive(false);
            }
        }
    }
    public void Continue()
    {
        if(currentStep < steps.Count - 1)
        {
            steps[currentStep].SetActive(false);
            currentStep++;
            steps[currentStep].SetActive(true);
        }
        else
        {
            steps[currentStep].SetActive(false);
            currentStep = 0;
            steps[currentStep].SetActive(true);
            menuCanvas.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }
}
