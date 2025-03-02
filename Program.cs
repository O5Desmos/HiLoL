using Microsoft.Win32;

Console.WriteLine("Hey lol");

const string userRoot = "HKEY_CURRENT_USER";
const string subkey = "Software\\Microsoft\\Windows\\CurrentVersion\\Themes\\Personalize";
const string keyName = userRoot + "\\" + subkey;

Registry.SetValue(keyName, "AppsUseLightTheme",0, RegistryValueKind.DWord);
Console.WriteLine("\"AppsUseLightTheme\" is now false");

Registry.SetValue(keyName, "SystemUsesLightTheme",0, RegistryValueKind.DWord);
Console.WriteLine("\"SystemUsesLightTheme\" is now false");

Console.WriteLine("You're Welcome (press any key to exit.)");
Console.ReadKey();

