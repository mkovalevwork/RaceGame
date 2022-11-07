using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField] private string carName;
    [SerializeField] private float carSpeedForward;
    [SerializeField] private float carSpeedRotation;

    public string CarName { get { return carName; } }  //readonly
    public float CarSpeedForward { get { return carSpeedForward; } }  //readonly
    public float CarSpeedRotation { get { return carSpeedRotation; } }  //readonly
}