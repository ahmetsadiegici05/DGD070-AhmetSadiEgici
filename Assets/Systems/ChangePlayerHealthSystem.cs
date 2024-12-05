using Entitas;
using UnityEngine;

public class ChangePlayerHealthSystem : IExecuteSystem
{
    private readonly GameContext _context;

    public ChangePlayerHealthSystem(Contexts contexts)
    {
        _context = contexts.game;
    }

    public void Execute()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            var entity = _context.CreateEntity();
            entity.isPlayerDamagedComponent = true;
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            var entity = _context.CreateEntity();
            entity.isPlayerHealedComponent = true;
        }
    }
}