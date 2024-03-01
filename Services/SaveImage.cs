using System;
using System.IO;
using System.Windows;
using Microsoft.Win32;

public static class FileManager
{
    public static void SaveImage()
    {
        try
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Fișiere imagine|*.jpg;*.jpeg;*.png;*.bmp|Toate fișierele|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                string filePath = openFileDialog.FileName;
                byte[] fileContent = File.ReadAllBytes(filePath);
                File.WriteAllBytes(filePath, fileContent);
                MessageBox.Show("Imaginea a fost salvată cu succes!", "Salvare cu succes", MessageBoxButton.OK, MessageBoxImage.Information);
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"A apărut o eroare la salvarea imaginii: {ex.Message}", "Eroare la salvare", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
