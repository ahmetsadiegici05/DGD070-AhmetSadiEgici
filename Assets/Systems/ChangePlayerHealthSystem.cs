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
        var playerEntity = _context.GetGroup(GameMatcher.PlayerHealth).GetSingleEntity();

        if (playerEntity == null)
        {
            Debug.LogError("Player entity not found!");
            return;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            playerEntity.isPlayerDamaged = true;
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            playerEntity.isPlayerHealed = true;
        }
    }
}
