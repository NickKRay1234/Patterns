using UnityEngine;

public class DIAGONAL : MonoBehaviour, ICommand
{
    private Transform _model;

    public DIAGONAL(Transform model)
    {
        _model = model;
    }
    public  void Execute() => _model.position += new Vector3(50f, -50f, 0f) * 100f;

    public  void Undo() => _model.position -= new Vector3(50f, -50f, 0f) * 100f;
}