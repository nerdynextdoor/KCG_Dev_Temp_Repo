//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public ShipComponent ship { get { return (ShipComponent)GetComponent(GameComponentsLookup.Ship); } }
    public bool hasShip { get { return HasComponent(GameComponentsLookup.Ship); } }

    public void AddShip(float newAccelerationRate, float newRotationRate) {
        var index = GameComponentsLookup.Ship;
        var component = (ShipComponent)CreateComponent(index, typeof(ShipComponent));
        component.accelerationRate = newAccelerationRate;
        component.rotationRate = newRotationRate;
        AddComponent(index, component);
    }

    public void ReplaceShip(float newAccelerationRate, float newRotationRate) {
        var index = GameComponentsLookup.Ship;
        var component = (ShipComponent)CreateComponent(index, typeof(ShipComponent));
        component.accelerationRate = newAccelerationRate;
        component.rotationRate = newRotationRate;
        ReplaceComponent(index, component);
    }

    public void RemoveShip() {
        RemoveComponent(GameComponentsLookup.Ship);
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

    static Entitas.IMatcher<GameEntity> _matcherShip;

    public static Entitas.IMatcher<GameEntity> Ship {
        get {
            if (_matcherShip == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Ship);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherShip = matcher;
            }

            return _matcherShip;
        }
    }
}
