using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    // ENCAPSULATION
    protected int point { get; set; }

    protected PlayerController playerController;

    private void Awake()
    {
        playerController = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    public void addPoint()
    {
        playerController.points += point;
        makeSound();
    }

    public void minusPoint()
    {
        playerController.points -= point;
        makeSound();
    }

    protected abstract void makeSound();
}
