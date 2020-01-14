using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{
    [SerializeField] private GameObject[] BallPos;
    [SerializeField] private GameObject Ball;
    public int lastNumber;
    public int RandomNumber;

    public void SetBallRandom() {
        Ball.transform.position = BallPos[RandomValue()].transform.position;
    }
    int RandomValue() {
        RandomNumber = UnityEngine.Random.Range(0,4);
        while(RandomNumber == lastNumber) {
           RandomNumber = UnityEngine.Random.Range(0,4); 
        }
        lastNumber = RandomNumber;
        return RandomNumber;
    }

    // # copyright by Kilian

}
