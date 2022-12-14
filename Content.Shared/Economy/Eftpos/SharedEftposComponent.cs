using Content.Shared.Containers.ItemSlots;
using Content.Shared.FixedPoint;
using Robust.Shared.GameStates;
using Robust.Shared.Serialization;

namespace Content.Shared.Economy.Eftpos
{
    [NetworkedComponent()]
    public abstract class SharedEftposComponent : Component
    {



        [Serializable, NetSerializable]
        public sealed class EftposBoundUserInterfaceState : BoundUserInterfaceState
        {
            public readonly FixedPoint2? Value;
            public readonly string? LinkedAccountNumber;
            public readonly string? LinkedAccountName;
            public readonly bool IsLocked;
            public EftposBoundUserInterfaceState(FixedPoint2? value, string? linkedAccountNumber, string? linkedAccountName, bool isLocked)
            {
                Value = value;
                LinkedAccountNumber = linkedAccountNumber;
                LinkedAccountName = linkedAccountName;
                IsLocked = isLocked;
            }
        }
    }
}
