using Entitas;
using UnityEngine;

public class PlayerHealthFeature : MonoBehaviour
{
    private Systems _systems;

    void Start()
    {
        var contexts = Contexts.sharedInstance;
        _systems = new Feature("PlayerHealthFeature")
            .Add(new CreatePlayerHealthSystem(contexts))
            .Add(new CheckPlayerHealthSystem(contexts))
            .Add(new ChangePlayerHealthSystem(contexts));

        _systems.Initialize();
    }

    void Update()
    {
        _systems.Execute();
        _systems.Cleanup();
    }
}
