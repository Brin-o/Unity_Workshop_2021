using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class textwriting : MonoBehaviour
{
    public InputField input;
    public string anwser;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        anwser = input.text;
    }
}
