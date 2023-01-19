using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputScript : MonoBehaviour
{
    public Toggle USD;
    public Toggle JPY;

    public Text value;

    public string input;
    public double InputValue;
  
    public void Start()
    {
 
    }

    // Update is called once per frame
    void Update()
    {
        if (USD.isOn)
        {
            JPY.isOn = false;
        }
        else if (JPY.isOn)
        {
            USD.isOn = false;
        }
        
       
        
    }

    public void ReadStringInput(string s)
    {
        input = s;

        double.TryParse(input, out InputValue);
    }

    public void convert_button()
    {
        if (USD.isOn)
        {
            InputValue *= 0.74f;
            value.text = "" + InputValue;
        }
        if (JPY.isOn)
        {
            InputValue *= 97.14f;
            value.text = "" + InputValue;
        }


       
    }

    public void clear_button(InputField s)
    {
        s.text = "" + 0;
        value.text = "" + s;
    }
}
