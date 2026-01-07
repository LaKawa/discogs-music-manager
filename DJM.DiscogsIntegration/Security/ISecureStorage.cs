namespace DJM.DiscogsIntegration.Security;

public interface ISecureStorage
{
   void Save(string key, string value);
   string Load(string key);
}