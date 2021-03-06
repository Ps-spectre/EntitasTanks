//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGenerator.ComponentExtensionsGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Entitas {
    public partial class Entity {
        public StartPositionComponent startPosition { get { return (StartPositionComponent)GetComponent(ComponentIds.StartPosition); } }

        public bool hasStartPosition { get { return HasComponent(ComponentIds.StartPosition); } }

        public Entity AddStartPosition(UnityEngine.Vector3 newValue) {
            var component = CreateComponent<StartPositionComponent>(ComponentIds.StartPosition);
            component.value = newValue;
            return AddComponent(ComponentIds.StartPosition, component);
        }

        public Entity ReplaceStartPosition(UnityEngine.Vector3 newValue) {
            var component = CreateComponent<StartPositionComponent>(ComponentIds.StartPosition);
            component.value = newValue;
            ReplaceComponent(ComponentIds.StartPosition, component);
            return this;
        }

        public Entity RemoveStartPosition() {
            return RemoveComponent(ComponentIds.StartPosition);
        }
    }

    public partial class Matcher {
        static IMatcher _matcherStartPosition;

        public static IMatcher StartPosition {
            get {
                if (_matcherStartPosition == null) {
                    var matcher = (Matcher)Matcher.AllOf(ComponentIds.StartPosition);
                    matcher.componentNames = ComponentIds.componentNames;
                    _matcherStartPosition = matcher;
                }

                return _matcherStartPosition;
            }
        }
    }
}
