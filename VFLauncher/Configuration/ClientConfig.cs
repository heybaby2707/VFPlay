using System.IO;

namespace Configuration
{
    public static class ClientConfig
    {
        static Config config = new Config("./ClientConfig.conf");

        //public static int BindClient = config.Read<int>("Bind.Client", 1);
        public static string BindIP = config.Read("Bind.IP", "vfire-sys.myvnc.com");
        public static int BindPort = config.Read<int>("Bind.Port", 3446);
        
        //public static int WoWClient = config.Read<int>("WoW.Client", 1);
        public static string WoWIP = config.Read("WoW.IP", "vfire-wow.myvnc.com");
        public static int WoWPort = config.Read<int>("WoW.Port", 8085);

        //public static int AionClient = config.Read<int>("Aion.Client", 1);
        public static string AionIP = config.Read("Aion.IP", "vfire-aion.myvnc.com");
        public static int AionPort = config.Read<int>("Aion.Port", 7777);

        public static void WriteClientConfig()
        {
            string ClientConfigFile = "./ClientConfig.conf";
            string str 
                //= "Bind.Client =		" + ClientConfig.BindClient + "\n"
                = "Bind.IP		=		" + ClientConfig.BindIP + "\n"
                + "Bind.Port	=		" + ClientConfig.BindPort + "\n"
                //+ "WoW.Client  =		" + ClientConfig.WoWClient + "\n"
                + "WoW.IP		=		" + ClientConfig.WoWIP + "\n"
                + "WoW.Port	=		" + ClientConfig.WoWPort + "\n"
                //+ "Aion.Client =		" + ClientConfig.AionClient + "\n"
                + "Aion.IP		=		" + ClientConfig.AionIP + "\n"
                + "Aion.Port	=		" + ClientConfig.AionPort + "\n";

            if (File.Exists(ClientConfigFile))
                File.Delete(ClientConfigFile);
            File.WriteAllText(ClientConfigFile, str);
        }
    }
}