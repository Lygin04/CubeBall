using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DistanceCalculation : MonoBehaviour
{
    [SerializeField] private Transform _redCube, _greenCube;

    [SerializeField] private TextMeshProUGUI _distanceTxt;

    [SerializeField] private GameObject _balls;
    
    private void FixedUpdate()
    {
        float dist = Vector3.Distance(_redCube.position, _greenCube.position);
        _distanceTxt.text = dist.ToString("0.#");
        
        if(dist > 2) _balls.SetActive(true);
        else if(dist < 2) _balls.SetActive(false);
        if (dist < 1) SceneManager.LoadScene("Scene 2");
    }
}
