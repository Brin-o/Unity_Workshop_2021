using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private void Awake()
    {
        if (instance == null)
            instance = this;
        else
            Destroy(this.gameObject);
    }


    public int highscore = 0;
    public float timer = 0;
    public GameObject pickup;
    public InputField input;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 5)
        {
            timer = 0;
            print("hello class how are you doing");
            var spawnedObject = Instantiate(pickup);
            var spawnX = Random.Range(-3, 3);
            spawnedObject.transform.position = new Vector2(spawnX, 4);
        }
    }
}
