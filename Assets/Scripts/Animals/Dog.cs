using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Dog : Animal
{
    // Start is called before the first frame update
    void Start()
    {
        point = 10;
    }

    // POLYMORPHISM
    protected override void makeSound()
    {
        Debug.Log("Brak");
    }
}
