using UnityEngine;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    [SerializeField] private Car chosenCar;
    [SerializeField] private GameObject mainCamera;
    [SerializeField] private UIManager UIManager;
    [SerializeField] private GameObject[] cars;
    [SerializeField] private Transform[] camerasPositions; //5pos for main menu position
    private int carIndex = 0;


    //StartManuChoseButton
    public void ChoseCarButton()
    {
        mainCamera.transform.position = camerasPositions[carIndex].position;
        mainCamera.transform.eulerAngles = camerasPositions[carIndex].eulerAngles;
        UIManager.mainCanvas.SetActive(false);
        UIManager.chooseCarCanvas.SetActive(true);
    }

    //ChooseMenuChooseButton
    public void ChooseButton()
    {
        chosenCar = cars[carIndex].GetComponent<Car>();
        mainCamera.transform.position = camerasPositions[5].position;
        mainCamera.transform.eulerAngles = camerasPositions[5].eulerAngles;
        UIManager.chooseCarCanvas.SetActive(false);
        UIManager.mainCanvas.SetActive(true);
        UIManager.actualCarText.GetComponent<Text>().text = chosenCar.carName;
    }

    public void NextCarButton()
    {
        if (carIndex!=4)
        {
            carIndex++;
        }
        else
        {
            carIndex = 0;
        }
        Debug.Log(carIndex);
        mainCamera.transform.position = camerasPositions[carIndex].position;
        mainCamera.transform.eulerAngles = camerasPositions[carIndex].eulerAngles;
    }

    public void PreviousCarButton()
    {
        if (carIndex != 0)
        {
            carIndex--;
        }
        else
        {
            carIndex = 4;
        }
        Debug.Log(carIndex);
        mainCamera.transform.position = camerasPositions[carIndex].position;
        mainCamera.transform.eulerAngles = camerasPositions[carIndex].eulerAngles;
    }
}