namespace ExercisePoint3D
{
    using System;
    using System.IO;
    public static class PathStorage
    {
        public static void SavePath(Path temp)
        {

            using (StreamWriter writer = new StreamWriter(@"../../PathsDatabase.txt"))
            {
                foreach (var i in temp.Paths)
                {
                    writer.WriteLine(String.Format("({0},{1},{2})", i.X, i.Y, i.Z));
                    writer.Flush();
                }
            }
        }

        internal static Path LoadPath()
        {
            Path loadPath = new Path();
            try
            {
                using (StreamReader reader = new StreamReader(@"../../PathsDatabase.txt"))
                {
                    while (reader.Peek() >= 0)
                    {
                        String line = reader.ReadLine();
                        String[] splittedLine = line.Split(new char[] { '(', ',', ')' }, StringSplitOptions.RemoveEmptyEntries);
                        loadPath.AddPoint(new Point3D(int.Parse(splittedLine[0]), int.Parse(splittedLine[1]), int.Parse(splittedLine[2])));
                    }
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }
            catch (IOException io)
            {
                Console.WriteLine(io.Message);
            }
            catch (OutOfMemoryException ome)
            {
                Console.WriteLine(ome.Message);
            }
            finally { }
            return loadPath;
        }
    }
}