using System;
using System.IO;
using System.Windows;
using Microsoft.Win32;

public static class FileManager
{
    public static string SaveImage()
    {
        try
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Fișiere imagine|*.jpg;*.jpeg;*.png;*.bmp|Toate fișierele|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                string sourceFilePath = openFileDialog.FileName; 

                string resourcesDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources");

                if (!Directory.Exists(resourcesDirectory))
                {
                    Directory.CreateDirectory(resourcesDirectory);
                }

                string fileName = Path.GetFileName(sourceFilePath); 
                string destinationFilePath = Path.Combine(resourcesDirectory, fileName);

                if (File.Exists(destinationFilePath))
                {
                    return $"./Resources/{fileName}"; 
                }


                File.Copy(sourceFilePath, destinationFilePath, true);

                MessageBox.Show($"Imaginea a fost salvată cu succes în {destinationFilePath}!", "Salvare cu succes", MessageBoxButton.OK, MessageBoxImage.Information);

                string relativeUriPath = $"./Resources/{fileName}";
                return relativeUriPath;

            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"A apărut o eroare la salvarea imaginii: {ex.Message}", "Eroare la salvare", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        return null;
    }
}
