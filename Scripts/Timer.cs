using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] Text _timerText;
    private float _time;
    private bool _isPlaying;
    [SerializeField,Range(1,100)] int _coolDown = 5;
    private void Start()
    {
        _timerText = gameObject.GetComponent<Text>();
        _isPlaying = true;
    }
    private void Update()
    {     
        if (_isPlaying)
        {
            if (_timerText != null)
            {
                _time += Time.deltaTime;
                if (_time < _coolDown)
                {
                    _timerText.text = _time.ToString("0.0");
                }
                else
                {
                    Debug.Log("<color=green>Timer is over at " + _time.ToString("0.0") + "</color>"); _isPlaying = false;
                }
            }
            else { Debug.LogWarning("<color=red>Fatal error:</color> The _timerText was not found"); }
        }
        
    }
}
