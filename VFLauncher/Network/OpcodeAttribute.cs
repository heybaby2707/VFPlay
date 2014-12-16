using Data.NetMessage;
using System;

namespace Network
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public sealed class OpcodeAttribute : Attribute
    {
        public ServerMessage Opcode { get; set; }
        public string WoWBuild { get; set; }

        public OpcodeAttribute(ServerMessage opcode, string wowBuild)
        {
            Opcode = opcode;
            WoWBuild = wowBuild;
        }
    }
}
