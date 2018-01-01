using GrandTheftMultiplayer.Server;
using GrandTheftMultiplayer.Server.API;
using GrandTheftMultiplayer.Server.Elements;
using GrandTheftMultiplayer.Server.Constant;
using GrandTheftMultiplayer.Server.Managers;
using GrandTheftMultiplayer.Shared;
using GrandTheftMultiplayer.Shared.Math;
using TheGodfatherGM.Server.User;

namespace TheGodfatherGM.Server.Extensions
{
    public static class ClientExtensions
    {
        public static AccountController GetAccountController(this Client client)
        {
            return client.getData("ACCOUNT") as AccountController;
        }
    }
}
