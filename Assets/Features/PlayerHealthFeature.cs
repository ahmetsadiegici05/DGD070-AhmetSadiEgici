using Entitas;

public class PlayerHealthFeature : Feature
{
    private GameContext _context;

    public PlayerHealthFeature(Contexts contexts)
    {
        _context = contexts.game;

        
        Add(new CreatePlayerHealthSystem(contexts)); 
        Add(new CheckPlayerHealthSystem(contexts));  
        Add(new ChangePlayerHealthSystem(contexts)); 
    }

    public sealed override Systems Add(ISystem system)
    {
        return base.Add(system);
    }
}
