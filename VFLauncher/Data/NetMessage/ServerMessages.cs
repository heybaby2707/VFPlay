namespace Data.NetMessage
{
    public enum ServerMessage : ushort
    {
        SV_AUTH_LOGIN = 0x0001,
        SV_AUTH_RECONNECT = 0x0002,
        SV_GET_CHANNEL_LIST = 0x0003,
		SV_REQUEST_ONLINE = 0x0004,
		SV_TRANSFER_INIT = 0x0005,
        SV_GET_ACCOUNT_INFO = 0x0006,

        SV_CHANNEL_JOIN = 0x0007,
        SV_CHANNEL_MESSAGE = 0x0008,
        SV_CHANNEL_OPEN = 0x0009,

        SV_ACCOUNT_CREATE = 0x0010,
        SV_ACCOUNT_ACTIVATE = 0x0011,

        TransferInitiate = 0x1000,
        DoPing = 0x1001,
        DisconnectFromServer = 0x1002,
    }
}
