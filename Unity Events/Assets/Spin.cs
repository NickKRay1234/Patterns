using UnityEngine;

public class Spin : MonoBehaviour, ICommand
{
    private Transform _model;

    public Spin(Transform model)
    {
        _model = model;
    }
    public void Execute() => _model.Rotate(0,0,45);
    public void Undo() => _model.Rotate(0,0,-45);
}