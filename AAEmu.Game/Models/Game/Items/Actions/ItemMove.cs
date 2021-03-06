using AAEmu.Commons.Network;

namespace AAEmu.Game.Models.Game.Items.Actions
{
    public class ItemMove : ItemTask
    {
        private SlotType _fromSlotType;
        private byte _fromSlot;
        private ulong _fromItemId;
        private SlotType _toSlotType;
        private byte _toSlot;
        private ulong _toItemId;

        public ItemMove(SlotType fromSlotType, byte fromSlot, ulong fromItemId, SlotType toSlotType, byte toSlot, ulong toItemId)
        {
            _type = 8;
            _fromSlotType = fromSlotType;
            _fromSlot = fromSlot;
            _fromItemId = fromItemId;
            _toSlotType = toSlotType;
            _toSlot = toSlot;
            _toItemId = toItemId;
        }

        public override PacketStream Write(PacketStream stream)
        {
            base.Write(stream);

            stream.Write((byte) 0); // v
            stream.Write((byte) _fromSlotType); // v
            stream.Write((byte) 0); // v
            stream.Write(_fromSlot); // v

            stream.Write((byte) 0); // v
            stream.Write((byte) _toSlotType); // v
            stream.Write((byte) 0); // v
            stream.Write(_toSlot); // v

            stream.Write(_fromItemId);
            stream.Write(_toItemId); // i2

            stream.Write(0); //flags
            return stream;
        }
    }
}