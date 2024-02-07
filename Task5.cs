using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S8DZStreamAndBuffering
{
    class Task5
    {
        public static void TaskFive()
        {

        }

    }
    class FileTree
    {
        enum Format { txt, jpg, jpeg, mp4, mp3, pdf, cs, cpp}

        FolderNode root;

        private class FolderNode
        {
            string name;
            List<FolderNode>[] folders;
            List<FileNode>[] files;
        }
        private class FileNode
        {
            string name;
            double size;
            Format format;
            byte[] data;

            public string getFullName
            {
                get { return name + format; }
            }
            public string getlName
            {
                get { return name; }
            }
            public Format getFormat
            {
                get { return format; }
            }
        }
        private class List<T>
        {
            Node root;
            private class Node
            {
                Node next;
                T value;
            }
        }
    }
}
