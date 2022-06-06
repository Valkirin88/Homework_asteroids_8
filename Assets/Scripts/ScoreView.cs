using UnityEngine;
using UnityEngine.UI;

public class ScoreView : MonoBehaviour
{

    private Canvas _mainCanvas;
    private const string _canvas = "Canvas";
    [SerializeField]public string Score;
    [SerializeField]private Text scoreText;


    private void Awake()
    {
        _mainCanvas = Resources.Load<Canvas>(_canvas);
    }

    private void Update()
    {
       scoreText.text = Score;
    }

}
