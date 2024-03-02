
using System;
using System.Globalization;
using System.IO;
using System.Windows.Data;
using System.Windows.Media.Imaging;

namespace Dictionary.Converters
{
    public class StringToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is string imagePath && !string.IsNullOrEmpty(imagePath))
            {
                try
                {
                    if (imagePath.StartsWith("pack://"))
                    {
                        return new BitmapImage(new Uri(imagePath, UriKind.Absolute));
                    }
                    else
                    {
                        string basePath = AppDomain.CurrentDomain.BaseDirectory;
                        string fullPath = Path.Combine(basePath, imagePath.TrimStart('.', '/').Replace('/', Path.DirectorySeparatorChar));

                        return new BitmapImage(new Uri(fullPath, UriKind.Absolute));
                    }
                }
                catch (Exception)
                {
                    return null;
                }
            }
            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
