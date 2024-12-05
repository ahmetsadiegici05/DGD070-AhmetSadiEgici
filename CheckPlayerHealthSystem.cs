using Entitas;

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
            if (entity.hasPlayerDamagedComponent)
            {
                entity.ReplacePlayerHealth(Mathf.Max(0, entity.playerHealth.Value - 10));
                entity.RemovePlayerDamagedComponent();
            }

            if (entity.hasPlayerHealedComponent)
            {
                entity.ReplacePlayerHealth(Mathf.Min(100, entity.playerHealth.Value + 10));
                entity.RemovePlayerHealedComponent();
            }
        }
    }
}
