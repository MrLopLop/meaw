using Robust.Shared.Prototypes;

namespace Content.Shared._NC.Crafting.Components
{
    [RegisterComponent]
    public sealed partial class STBlueprintComponent : Component
    {
        [DataField("blueprint")]
        public EntProtoId? BlueprintId = null;
    }
}
