using Entitas;
using UnityEngine;

public class CheckPlayerHealthSystem : IExecuteSystem
{
    private readonly GameContext _context;

    public CheckPlayerHealthSystem(Contexts contexts)
    {
        _context = contexts.game;
    }

    public void Execute()
    {
        var entities = _context.GetGroup(GameMatcher.PlayerHealth).GetEntities();

        foreach (var entity in entities)
        {
            if (entity.isPlayerDamaged)
            {
                entity.ReplacePlayerHealth(Mathf.Max(0, entity.playerHealth.Value - 10));
                entity.isPlayerDamaged = false;
            }

            if (entity.isPlayerHealed)
            {
                entity.ReplacePlayerHealth(Mathf.Min(100, entity.playerHealth.Value + 10));
                entity.isPlayerHealed = false;
            }
        }
    }
}
