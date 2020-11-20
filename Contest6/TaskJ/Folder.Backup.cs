using System;
using System.Collections.Generic;
using System.Text;

partial class Folder
{
    internal class Backup
    {
        internal Folder folder;

        public Backup(Folder folder)
        {
            this.folder = new Folder();
            this.folder.files.AddRange(folder.files);
        }

        public Folder Folder
        {
            get => folder;
            internal set
            {
                folder = value;
            }
        }


        public static void Restore(Folder folder, Backup backup)
        {
            folder.files = backup.Folder.files;
        }

    }

    public void AddFile(string name, int size)
    {
        files.Add(new File(name, size));
    }
    public void RemoveFile(File file)
    {
        files.Remove(file);
    }

    public File this[int i]
    {
        get {
            if (i < 0 || i >= files.Count)
            {
                throw new IndexOutOfRangeException("Not enough files or index less zero");
            }
            return files[i];
        }
    }

    public File this[string filename]
    {
        get {
            foreach (var file in files)
            {
                if (filename.Equals(file.Name))
                {
                    return file;
                }
            }
            throw new ArgumentException("File not found");
        }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("Files in folder:");
        foreach (var file in files)
        {
            sb.Append(Environment.NewLine);
            sb.Append(file.ToString());
        }
        return sb.ToString();
    }
}

