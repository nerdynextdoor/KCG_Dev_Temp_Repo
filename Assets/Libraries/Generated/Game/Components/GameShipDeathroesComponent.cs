//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly ShipDeathroesComponent shipDeathroesComponent = new ShipDeathroesComponent();

    public bool isShipDeathroes {
        get { return HasComponent(GameComponentsLookup.ShipDeathroes); }
        set {
            if (value != isShipDeathroes) {
                var index = GameComponentsLookup.ShipDeathroes;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : shipDeathroesComponent;

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

    static Entitas.IMatcher<GameEntity> _matcherShipDeathroes;

    public static Entitas.IMatcher<GameEntity> ShipDeathroes {
        get {
            if (_matcherShipDeathroes == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.ShipDeathroes);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherShipDeathroes = matcher;
            }

            return _matcherShipDeathroes;
        }
    }
}
