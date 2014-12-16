using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Reflection;
using Data.NetMessage;
using Network;
using System.Windows.Forms;

namespace Packets
{
    public class PacketManager
    {
        static Dictionary<ServerMessage, HandlePacket> OpcodeHandlers = new Dictionary<ServerMessage, HandlePacket>();
        delegate void HandlePacket(ref PacketReader packet, NetClient session);
        
        public static void DefineOpcodeHandler()
        {
            Assembly currentAsm = Assembly.GetExecutingAssembly();
            foreach (var type in currentAsm.GetTypes())
            {
                foreach (var methodInfo in type.GetMethods())
                {
                    foreach (OpcodeAttribute opcodeAttr in methodInfo.GetCustomAttributes(typeof(OpcodeAttribute), false)){
                        if (opcodeAttr != null)
                            OpcodeHandlers[opcodeAttr.Opcode] = (HandlePacket)Delegate.CreateDelegate(typeof(HandlePacket), methodInfo);
                    }
                }
            }
        }
        
        public static void InvokeHandler(ref PacketReader reader, NetClient session)
        {
            /*
            if (session.Character != null)
            {
                ulong charGuid = session.Character.Guid;

                if (WorldMgr.Sessions.ContainsKey(charGuid))
                    WorldMgr.Sessions[charGuid] = session;
            }
            */
            if (OpcodeHandlers.ContainsKey(reader.Opcode))
                OpcodeHandlers[reader.Opcode].Invoke(ref reader, session);
            //else
                //Log.Message(LogType.Dump, "Unknown Opcode: {0} (0x{1:X}), Length: {2}", reader.Opcode, reader.Opcode, reader.Size);
        }
    }
}
