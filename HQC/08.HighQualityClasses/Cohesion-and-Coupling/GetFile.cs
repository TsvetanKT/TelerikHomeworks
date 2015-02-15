namespace CohesionAndCoupling
{
    using System;

    public static class GetFile
    {      
        public const int MIN_NAME_LENGHT = 3; // One char for name, one for '.' and one for extension.

        public static string Extension(string fileName)
        {
            int indexOfLastDot = IndexOfDot(fileName, MIN_NAME_LENGHT);
            string extension = fileName.Substring(indexOfLastDot + 1);
            return extension;
        }

        public static string Name(string fileName)
        {
            int indexOfLastDot = IndexOfDot(fileName, MIN_NAME_LENGHT);
            string extension = fileName.Substring(0, indexOfLastDot);
            return extension;
        }

        private static int IndexOfDot(string fileName, int minNameLenght)
        {
            int index = fileName.LastIndexOf(".");
            if (fileName.Trim().Length < minNameLenght)
            {
                throw new FormatException("File name too short.");
            }
  
            if (index == -1)
            {
                throw new FormatException("Bad File Name - missing extension separator (dot).");
            }

            return index;
        }
    }
}
