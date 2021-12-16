using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerMenu : MonoBehaviour
{
    public GameObject Menu;
    public GameObject ButtonOneSpawner;
    public GameObject ButtonTwoSpawner;
    public GameObject ButtonThreeSpawner;
    public GameObject ButtonFourSpawner;
    public GameObject ButtonFiveSpawner;
    public GameObject ButtonSixSpawner;
    public GameObject ButtonSevenSpawner;
    public GameObject ButtonEightSpawner;
    public GameObject ButtonNineSpawner;
    public GameObject ButtonTenSpawner;

    public void ButtonOne()
    {
        Vector3 position = new Vector3(Random.Range(-45.0f, 45.0f), 5.0f, Random.Range(-45.0f, 45.0f));
        Instantiate(ButtonOneSpawner, position, Quaternion.identity);
    }

    public void ButtonTwo()
    {
        Vector3 position = new Vector3(Random.Range(-45.0f, 45.0f), 5.0f, Random.Range(-45.0f, 45.0f));
        Instantiate(ButtonTwoSpawner, position, Quaternion.identity);
    }

    public void ButtonThree()
    {
        Vector3 position = new Vector3(Random.Range(-45.0f, 45.0f), 5.0f, Random.Range(-45.0f, 45.0f));
        Instantiate(ButtonThreeSpawner, position, Quaternion.identity);
    }

    public void ButtonFour()
    {
        Vector3 position = new Vector3(Random.Range(-45.0f, 45.0f), 5.0f, Random.Range(-45.0f, 45.0f));
        Instantiate(ButtonFourSpawner, position, Quaternion.identity);
    }

    public void ButtonFive()
    {
        Vector3 position = new Vector3(Random.Range(-45.0f, 45.0f), 5.0f, Random.Range(-45.0f, 45.0f));
        Instantiate(ButtonFiveSpawner, position, Quaternion.identity);
    }

    public void ButtonSix()
    {
        Vector3 position = new Vector3(Random.Range(-45.0f, 45.0f), 5.0f, Random.Range(-45.0f, 45.0f));
        Instantiate(ButtonSixSpawner, position, Quaternion.identity);
    }

    public void ButtonSeven()
    {
        Vector3 position = new Vector3(Random.Range(-45.0f, 45.0f), 5.0f, Random.Range(-45.0f, 45.0f));
        Instantiate(ButtonSevenSpawner, position, Quaternion.identity);
    }

    public void ButtonEight()
    {
        Vector3 position = new Vector3(Random.Range(-45.0f, 45.0f), 5.0f, Random.Range(-45.0f, 45.0f));
        Instantiate(ButtonEightSpawner, position, Quaternion.identity);
    }

    public void ButtonNine()
    {
        Vector3 position = new Vector3(Random.Range(-45.0f, 45.0f), 5.0f, Random.Range(-45.0f, 45.0f));
        Instantiate(ButtonNineSpawner, position, Quaternion.identity);
    }

    public void ButtonTen()
    {
        Vector3 position = new Vector3(Random.Range(-45.0f, 45.0f), 5.0f, Random.Range(-45.0f, 45.0f));
        Instantiate(ButtonTenSpawner, position, Quaternion.identity);
    }
}
