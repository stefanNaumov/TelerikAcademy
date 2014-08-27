using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace FilesAndFoldersTrav
{
    public class FileFolderTree
    {
        private Folder root;

        public FileFolderTree(Folder root)
        {
            this.root = root;
            this.TraverseFolderTree(this.root);
        }

        public long CalcFileSizesSum()
        {
            long sum = 0;
            this.CalculateFileSizes(this.root, ref sum);

            return sum;
        }

        private long CalculateFileSizes(Folder folder, ref long sum)
        {
            if (folder == null || folder.Files == null)
            {
                return sum;
            }
            for (int i = 0; i < folder.Files.Length; i++)
            {
                sum += folder.Files[i].Size;
            }

            for (int i = 0; i < folder.ChildFolders.Length; i++)
            {
                CalculateFileSizes(folder.ChildFolders[i], ref sum);
            }

            return sum;
        }

        private Folder TraverseFolderTree(Folder root)
        {
            string[] folders = Directory.GetDirectories(root.Name);
            string[] files = Directory.GetFiles(root.Name);

            this.AddFilesToFolder(root, files);
            this.AddChildrenFoldersToFolder(root, folders);

            for (int i = 0; i < root.ChildFolders.Length; i++)
            {
                try
                {
                    TraverseFolderTree(root.ChildFolders[i]);
                }
                catch (UnauthorizedAccessException ex)
                {

                    continue;
                }
            }

            return root;
        }

        private void AddFilesToFolder(Folder rootFolder, string[] files)
        {
            List<File> currFolderFiles = new List<File>();

            for (int i = 0; i < files.Length; i++)
            {
                FileInfo currFileInfo = new FileInfo(files[i]);
                long size = currFileInfo.Length;

                File currFile = new File(files[i], (int)size);
                currFolderFiles.Add(currFile);
            }

            rootFolder.Files = currFolderFiles.ToArray();
        }

        private void AddChildrenFoldersToFolder(Folder rootFolder, string[] folders)
        {
            List<Folder> currFolderChildren = new List<Folder>();

            for (int i = 0; i < folders.Length; i++)
            {
                currFolderChildren.Add(new Folder(folders[i]));
            }

            rootFolder.ChildFolders = currFolderChildren.ToArray();
        }
    }
}
