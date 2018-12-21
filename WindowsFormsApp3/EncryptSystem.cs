using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3
{
    public interface EncryptSystem
    {
        string Name
        {
            get;set;
        }
        string Paths
        {
            get; set;
        }
        string Password
        {
            get; set;
        }
        bool Encrypted
        {
            get; set;
        }
        string EncryptionAlg
        {
            get;set;
        }
        string PasswordAlg
        {
            get;set;
        }
    }
}
