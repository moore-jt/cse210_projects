using System.IO;
using System.Text.Json;

public static class FileHandler
{
    private static string _defaultPath = "userData.json";

    public static bool SaveUserData(User u, string path)
    {
        try
        {
            // Convert the User object (and all nested Accounts/Transactions) into a JSON string
            JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented = true };
            string jsonData = JsonSerializer.Serialize(u, options);

            // Write the string to the physical file
            File.WriteAllText(path, jsonData);

            Console.WriteLine($"[SYSTEM] Data successfully saved to {path}.");
            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[ERROR] Failed to save data: {ex.Message}");
            return false;
        }
    }

    // LOAD: Reads the file and reconstructs the User object
    public static User LoadUserData(string path)
    {
        try
        {
            if (File.Exists(path))
            {
                string jsonData = File.ReadAllText(path);
                
                // Reconstruct the User object from the string
                User loadedUser = JsonSerializer.Deserialize<User>(jsonData);
                
                Console.WriteLine($"[SYSTEM] Welcome back, {loadedUser.Username}! Data loaded.");
                return loadedUser;
            }
            else
            {
                Console.WriteLine("[SYSTEM] No save file found. Starting fresh.");
                return null;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[ERROR] Failed to load data: {ex.Message}");
            return null;
        }
    }
}
    
