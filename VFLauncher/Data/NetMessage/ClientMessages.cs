namespace Data.NetMessage
{
    public enum ClientMessage : ushort
    {
        CL_AUTH_LOGIN = 0x0001,
        CL_AUTH_RECONNECT = 0x0002,
        CL_GET_CHANNEL_LIST = 0x0003,
		CL_REQUEST_ONLINE = 0x0004,
		CL_TRANSFER_INIT = 0x0005,
        CL_GET_ACCOUNT_INFO = 0x0006,

        CL_CHANNEL_JOIN = 0x0007,
        CL_CHANNEL_MESSAGE = 0x0008,
        CL_CHANNEL_OPEN = 0x0009,

        CL_ACCOUNT_CREATE = 0x0010,
        CL_ACCOUNT_ACTIVATE = 0x0011,

        TransferInitiate = 0x1000,
        DoPing = 0x1001,
        DisconnectFromServer = 0x1002,
    }
}