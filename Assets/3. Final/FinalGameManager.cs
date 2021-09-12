using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalGameManager : MonoBehaviour
{
    // SINGLETON
    // this will allow us to acess this object from any other script
    // you dont need to fully understand how this works!
    // just know that usually you only want ONE object in your game that is a singleton
    // i would recommend creating a GameManager object and then using it to store all of the referneces
    // if you make too many singletons your programmers that care about code arhitecture will probablly be sad.
    // dont make your programmers sad.
    public static FinalGameManager instance; //public static objects are acessible from any code by typing NameOfTheScript.NameOfTheStaticVariable
    void Awake()
    {
        if (FinalGameManager.instance == null) //we are checking if an instance does not exist
        {
            FinalGameManager.instance = this; //  
        }
        else
        {
            // having multiple singletons breaks things! unity wont know which one we are reffering to, so we destroy this object. its called SINGLEton for a reason.
            Destroy(this.gameObject);
        }
    }
    // SINGLETON CODE ENDS
    // everything below this line works normally like the rest of scripts with the excepcion that 
    // we can now access any variable/method that is public by typing:
    // FinalGameManager.instance.nameOfVariable

    public int score = 0;
    public GameObject pickup; //a gameobject variable type is simply any game object in our project. this can also be a prefab (our saved pickup object that is among project files)
    public float timer = 0;
    public float timeToSpawn = 5f;
    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= timeToSpawn)
        {
            timer = 0; //reset the timer so that it can count up again otherwise this will happen only once per game

            // Spawning an object
            // the easiest way to define a variable inside of a method is with "var"
            // Instantiate creates the object at coordinate (0,0)
            // to easily move the newly created object around we saved it as a variable
            var spawnedPickup = Instantiate(pickup);


            // we create two variables and assign them a random number
            var randomX = Random.Range(-5, 5);
            var randomY = Random.Range(-5, 5);
            // here we set the position of the spawned pickup (in its transform component) to these randomly assigned numbers
            spawnedPickup.transform.position = new Vector2(randomX, randomY);

        }
    }
}
