//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    static readonly PointerClickedComponent pointerClickedComponent = new PointerClickedComponent();

    public bool isPointerClicked {
        get { return HasComponent(GameComponentsLookup.PointerClicked); }
        set {
            if (value != isPointerClicked) {
                var index = GameComponentsLookup.PointerClicked;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : pointerClickedComponent;

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

    static Entitas.IMatcher<GameEntity> _matcherPointerClicked;

    public static Entitas.IMatcher<GameEntity> PointerClicked {
        get {
            if (_matcherPointerClicked == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.PointerClicked);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherPointerClicked = matcher;
            }

            return _matcherPointerClicked;
        }
    }
}
