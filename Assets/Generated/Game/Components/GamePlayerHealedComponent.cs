//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly PlayerHealedComponent playerHealedComponent = new PlayerHealedComponent();
    internal bool isPlayerHealedComponent;
    internal bool isPlayerDamagedComponent;

    public bool isPlayerHealed {
        get { return HasComponent(GameComponentsLookup.PlayerHealed); }
        set {
            if (value != isPlayerHealed) {
                var index = GameComponentsLookup.PlayerHealed;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : playerHealedComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherPlayerHealed;

    public static Entitas.IMatcher<GameEntity> PlayerHealed {
        get {
            if (_matcherPlayerHealed == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.PlayerHealed);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherPlayerHealed = matcher;
            }

            return _matcherPlayerHealed;
        }
    }
}
