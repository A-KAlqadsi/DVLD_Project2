using DVLD_Business;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_View.Globals
{
	public class Global
	{
		public static clsUser CurrentUser;
		private static string RegistryUserName = "UserName";
		private static string RegistryPassword = "Password";

		public static bool RememberUsernameAndPasswordFile(string Username, string Password)
		{

			try
			{
				//this will get the current project directory folder.
				string currentDirectory = System.IO.Directory.GetCurrentDirectory();


				// Define the path to the text file where you want to save the data
				string filePath = currentDirectory + "\\data.txt";

				//incase the username is empty, delete the file
				if (Username == "" && File.Exists(filePath))
				{
					File.Delete(filePath);
					return true;
				}

				// concatonate username and passwrod withe seperator.
				string dataToSave = Username + "#//#" + Password;

				// Create a StreamWriter to write to the file
				using (StreamWriter writer = new StreamWriter(filePath))
				{
					// Write the data to the file
					writer.WriteLine(dataToSave);

					return true;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An error occurred: {ex.Message}");
				return false;
			}

		}

		public static bool RememberUsernameAndPassword(string Username, string Password)
		{

			try
			{
				//incase the username is empty, delete the file
				if (Username == "" || Password == "")
				{
					DeleteRegistry(RegistryUserName);
					DeleteRegistry(RegistryPassword);
					return true;
				}

				WriteToWindowsRegistry(RegistryUserName, Username);
				WriteToWindowsRegistry(RegistryPassword, Password);
				
				return true;
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An error occurred: {ex.Message}");
				return false;
			}

		}

		public static bool GetStoredCredential(ref string Username, ref string Password)
		{
			//this will get the stored username and password and will return true if found and false if not found.
			try
			{
				Username = ReadFromWindowsRegistry(RegistryUserName);
				Password =ReadFromWindowsRegistry(RegistryPassword);
				return Username != "" && Password != "";
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An error occurred: {ex.Message}");
				return false;
			}

		}

		public static bool GetStoredCredentialFile(ref string Username, ref string Password)
		{
			//this will get the stored username and password and will return true if found and false if not found.
			try
			{
				//gets the current project's directory
				string currentDirectory = System.IO.Directory.GetCurrentDirectory();

				// Path for the file that contains the credential.
				string filePath = currentDirectory + "\\data.txt";

				// Check if the file exists before attempting to read it
				if (File.Exists(filePath))
				{
					// Create a StreamReader to read from the file
					using (StreamReader reader = new StreamReader(filePath))
					{
						// Read data line by line until the end of the file
						string line;
						while ((line = reader.ReadLine()) != null)
						{
							Console.WriteLine(line); // Output each line of data to the console
							string[] result = line.Split(new string[] { "#//#" }, StringSplitOptions.None);

							Username = result[0];
							Password = result[1];
						}
						return true;
					}
				}
				else
				{
					return false;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"An error occurred: {ex.Message}");
				return false;
			}

		}

		private static bool WriteToWindowsRegistry(string name, string data)
		{
			string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLD";
			string valueName = name;
			string valueData = data;

			try
			{
				// Write the value to the Registry
				Registry.SetValue(keyPath, valueName, valueData, RegistryValueKind.String);

				return true;
			}
			catch (Exception ex)
			{
				//Console.WriteLine($"An error occurred: {ex.Message}");
				return false;
			}
		}

		private static bool DeleteRegistry(string name)
		{
			// Specify the registry key path and value name
			string keyPath = @"SOFTWARE\DVLD";
			string valueName = name;

			try
			{
				// Open the registry key in read/write mode with explicit registry view
				using (RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser, RegistryView.Registry64))
				{
					using (RegistryKey key = baseKey.OpenSubKey(keyPath, true))
					{
						if (key != null)
						{
							// Delete the specified value
							key.DeleteValue(valueName);
						}
						
						return true;
					}
				}
			}
			catch (UnauthorizedAccessException)
			{
				Console.WriteLine("UnauthorizedAccessException: Run the program with administrative privileges.");
			}
			catch (Exception ex)
			{
				Console.WriteLine($"An error occurred: {ex.Message}");
			}
			return false;
		}
		
		private static string ReadFromWindowsRegistry(string name)
		{
			// Specify the Registry key and path
			string keyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLD";
			string valueName = name;

			try
			{
				string value = Registry.GetValue(keyPath, valueName, null) as string;


				if (value != null)
				{
					//Console.WriteLine($"Your value data for {valueName} is: {value}");
					return value;
				}
				
			}
			catch (Exception ex)
			{
				Console.WriteLine($"Error: {ex.Message}");
			}
			return "";
		}

		public static string ComputeHash(string input)
		{
			//SHA is Secutred Hash Algorithm.
			// Create an instance of the SHA-256 algorithm
			using (SHA256 sha256 = SHA256.Create())
			{
				// Compute the hash value from the UTF-8 encoded input string
				byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));

				// Convert the byte array to a lowercase hexadecimal string
				return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
			}
		}

	}
}
