namespace Data.Interfaces
{
    public interface IConnection
    {
        bool IsValid { get; }
        void Close();
        void PushPacket(byte[] data);
        long Ping();
    }
}
