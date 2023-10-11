using UnityEngine;
using UnityEngine.UI;

public class UpdateText : MonoBehaviour
{
    [SerializeField] private Text _text;

    private void OnEnable()
    {
        Ball.MoveBall += OnBallMoved;
    }

    private void OnDisable()
    {
        Ball.MoveBall -= OnBallMoved;
    }

    private void OnBallMoved(float positionZ)
    {
        EditText(positionZ);
    }

    private void EditText(float positionZ)
    {
        _text.text = "Position Z: " + positionZ;
    }
}
