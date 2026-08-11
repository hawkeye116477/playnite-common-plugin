using System.Runtime.InteropServices;
using GnomeStack.Secrets.Win32;
using GnomeStack.Standard;

namespace CommonPlugin;

public class Keyring
{
    public static void SetPassword(string servicename, string username, string password)
    {
        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
        {
            WinCredManager.SetSecret(servicename, username, password, false, null, WinCredPersistence.LocalMachine);
        }
        else
        {
            OsSecretVault.SetSecret(servicename, username, password);
        }
    }

    public static string? GetPassword(string servicename, string username)
    {
        return OsSecretVault.GetSecret(servicename, username);
    }
    
    public static void DeletePassword(string servicename, string username)
    {
        OsSecretVault.DeleteSecret(servicename, username);
    }
}