using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
   
    public class FilesFolder: EncryptSystem
    {
        private string _name;
        private string _path;
        private string _password;
        private bool _encrypted;
        private string _encryptAlg;
        private string _passwordAlg;

        public string Name
        {
            get { return _name; }
            set
            {
                _name = value;
            }
        }

        public string Paths
        {
            get { return _path; }
            set
            {
                _path = value;
            }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public bool Encrypted
        {
            get { return _encrypted; }
            set { _encrypted = value; }
        }

        public string EncryptionAlg
        {
            get { return _encryptAlg; }
            set { _encryptAlg = value; }
        }
        public string PasswordAlg
        {
            get { return _passwordAlg; }
            set { _passwordAlg = value; }
        }
    }
    public class FolderSystem : FilesFolder
    {
        public List<FilesFolder> AddnewFile(string path, string password, bool encry)
        {
            List<FilesFolder> Files = new List<FilesFolder>();
            foreach (var item in Directory.GetFiles(path))
            {
                FileInfo sp = new FileInfo(item);
                Files.Add(new FilesFolder
                {
                    Name = sp.Name,
                    Password = password,
                    Encrypted = encry,
                    Paths = item,
                    EncryptionAlg= "null",
                    PasswordAlg = "SHA-384 (48)"
                });
            }
            return Files;
        }
        
    }
}
