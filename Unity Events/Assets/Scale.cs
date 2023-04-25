using UnityEngine;
public class Scale : MonoBehaviour, ICommand
{
    private Transform _model;

    public Scale(Transform model)
    {
        _model = model;
    }
    public void Execute() => _model.localScale *= 2;
    public void Undo() => _model.localScale /= 2;
}