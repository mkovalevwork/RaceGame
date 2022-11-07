using System;
using UnityEngine;

[Serializable]
public class TestCar : MonoBehaviour
{
    public string CarName;
    public int Speed;

    private void Start()
    {
        TestCar testCar = new TestCar();
        testCar.CarName = "TestCar";
        testCar.Speed = 3;


        string json = JsonUtility.ToJson(testCar);
        Debug.Log(json);

        testCar = JsonUtility.FromJson<TestCar>(json);
    }
}
