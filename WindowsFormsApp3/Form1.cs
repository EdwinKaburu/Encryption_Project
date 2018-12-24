using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;
using System.IO;
using System.Security.AccessControl;
using Ionic.Zip;
using Newtonsoft.Json;

namespace WindowsFormsApp3
{
    
    public partial class Form1 : Form
    {
        FolderSystem systemFiles = new FolderSystem();

        List<FilesFolder> changingFiles = new List<FilesFolder>();

        Random random = new Random();

        string folderBrowser = String.Empty;

        string password = String.Empty;

        string[] items = new string[] { "MD5 (16)", "SHA-1 (20)", "SHA-256 (32)", "SHA-384 (48)", "SHA-512 (64)" };

        public Form1()
        {
            InitializeComponent();
           // metroTabControl2.SelectTab(0);
            passranBtn.Click += PassranBtn_Click;

            foreach(var item in items)
            {
                hashingCombo.Items.Add(item);
            }
          

            
        }

        private void selectBtn_Click(object sender, EventArgs e)
        {
        
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                //There is a Folder within this Selected Folder, Can't be Allowed
                if(Directory.GetDirectories(folderBrowserDialog1.SelectedPath).Any())
                {
                    //This Folder Should be Zipped
                    foreach (var item in Directory.GetDirectories(folderBrowserDialog1.SelectedPath))
                    {
                        MessageBox.Show("Folder within Encrypted Folder should be Zipped  \t" + item + "\n");
                    }
                }
                else
                {
                    
                    //Get the Folder Location Of Create or Already Existing Folder
                    txtFolderLocation.Text = folderBrowserDialog1.SelectedPath;

                    folderBrowser = folderBrowserDialog1.SelectedPath;

                    chk1.Checked = true;
                    //Checks if there is any files in Selected Folder
                    if (Directory.GetFiles(folderBrowserDialog1.SelectedPath).Any())
                    {
                        chk2.Checked = true;

                    }
                   
                    changingFiles = systemFiles.AddnewFile(folderBrowserDialog1.SelectedPath, "null", false);
                    metroGrid1.DataSource = changingFiles;
                }
                
            }
        }
        //Goes to the Next Encryption Page of Creation Tab
        private void btnNext_Click(object sender, EventArgs e)
        {
            if(chk1.Checked.Equals(true))
            {
                //Move from Folder Location to Encryption Process
                metroTabControl2.SelectTab(1);
                
            }
            else
            {
                MessageBox.Show("You Must Create a new Folder  to proceed");
            }
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {

            if (password.Length < 1)
            {
                MessageBox.Show("A Folder Password must be Entered: You can AutoGenerate the Password \t");
            }
            else
            {
                FileInfo fileInfo = new FileInfo(folderBrowser);
                               
                Directory.CreateDirectory(string.Format(@"{0}\{1}_Encrypted", fileInfo.DirectoryName, fileInfo.Name));

                string saveFile = string.Format(@"{0}\{1}_Encrypted\{1}.locked", fileInfo.DirectoryName, fileInfo.Name);

                using (ZipFile zip = new ZipFile())
                {
                    //Loop Thur the Folders
                    foreach (FilesFolder files in changingFiles)
                    {
                        // byte[] pass = Encoding.UTF8.GetBytes(files.Password); // Convert to 16 byte to used in the Key and IV for Encryption

                        byte[] pass = Encoding.UTF8.GetBytes(files.Password);

                        byte[] keyIv = MD5.Create().ComputeHash(pass); // 16 byte Key and Iv Key based on the File PassWord.

                        //Encrypt the Files Before Adding it to Zip Folder
                        EncryptFile(files.Paths, keyIv, keyIv);

                        //Get the Hashed Password
                        string hashed = String.Empty;
                        foreach (byte hash in HashedPassword(pass))
                        {
                            hashed += hash;
                        }

                        // If the password is null then it will be false
                        if (files.Password.Equals("null"))
                        {
                            files.Encrypted = false;
                        }
                        else
                        {
                            files.Encrypted = true;
                        }
                        files.EncryptionAlg = "AES";

                        if (hashingCombo.Text.Length < 1)
                        {
                            files.PasswordAlg = hashingCombo.PromptText;
                        }
                        else
                        {
                            files.PasswordAlg = hashingCombo.Text;
                        }

                        //Add Password to Encrypted File with Hashed Password
                        zip.Password = hashed;
                        //Add 
                        zip.AddFile(files.Paths);

                    }

                    zip.Save(saveFile);
                }

                // Get the Folder Password and Encrypt the Zip Folder
                byte[] folderkeyIv = MD5.Create().ComputeHash(Encoding.UTF8.GetBytes(password));
                //Folder is Encrypted 
                EncryptFile(saveFile, folderkeyIv, folderkeyIv);

                if (recoveryChks.Checked == true)
                {
                    if (hashingCombo.Text.Length < 1)
                    {
                        changingFiles.Add(new FilesFolder
                        {
                            Name = string.Format("{0}.locked", fileInfo.Name),
                            Encrypted = true,
                            Password = password,
                            Paths = saveFile,
                            EncryptionAlg = "AES",
                            PasswordAlg = hashingCombo.PromptText

                        });
                    }
                    else
                    {
                        changingFiles.Add(new FilesFolder
                        {
                            Name = string.Format("{0}.locked", fileInfo.Name),
                            Encrypted = true,
                            Password = password,
                            Paths = saveFile,
                            EncryptionAlg = "AES",
                            PasswordAlg = hashingCombo.Text

                        });
                    }

                    string json = JsonConvert.SerializeObject(changingFiles);

                    string recoverypath = string.Format(@"{0}\{1}_Encrypted\{1}.txt", fileInfo.DirectoryName, fileInfo.Name);

                    SaveRecovery(ASCIIEncoding.UTF8.GetBytes(json), recoverypath);


                }
                else
                {
                    if (hashingCombo.Text.Length < 1)
                    {
                        changingFiles.Add(new FilesFolder
                        {
                            Name = string.Format("{0}.locked", fileInfo.Name),
                            Encrypted = true,
                            Password = password,
                            Paths = saveFile,
                            EncryptionAlg = "AES",
                            PasswordAlg = hashingCombo.PromptText

                        });
                    }
                    else
                    {
                        changingFiles.Add(new FilesFolder
                        {
                            Name = string.Format("{0}.locked", fileInfo.Name),
                            Encrypted = true,
                            Password = password,
                            Paths = saveFile,
                            EncryptionAlg = "AES",
                            PasswordAlg = hashingCombo.Text

                        });
                    }
                    string json = JsonConvert.SerializeObject(changingFiles);
                    string recoverypath1 = string.Format(@"{0}\{1}_Encrypted\UnEncrypted.txt", fileInfo.DirectoryName, fileInfo.Name);
                    using (StreamWriter file = new StreamWriter(recoverypath1))
                    {
                        file.WriteLine(json);
                    }

                }
                //Display Where Folder is Saved
                savePoint.Text = saveFile;
                //Verify to User that Folder and Files are Encrypted
                filesEncryHashed.Checked = true;
                folderEncryAlgo.Checked = true;
                filesEncryHashed.Checked = true;
                folderEncryAlgo.Checked = true;
                //Delete the Folder 
                Directory.Delete(folderBrowser, true);
                changingFiles.Clear();

                metroGrid1.DataSource = null;

                MessageBox.Show("Your Encrypted Folder is At\t" + saveFile);
            }


        }
        private void SaveRecovery(byte[] data,string filepath)
        {
            byte[] key = { 145, 12, 32, 245, 98, 132, 98, 214, 6, 77, 131, 44, 221, 3, 9, 50 };
            byte[] iv = { 15, 122, 132, 5, 93, 198, 44, 31, 9, 39, 241, 49, 250, 188, 80, 7 };

            using (SymmetricAlgorithm algorithm = Aes.Create())
            {
                using (ICryptoTransform encryptor = algorithm.CreateEncryptor(key, iv))
                {
                    using (Stream f = File.Create(filepath))
                    {
                        using (Stream c = new CryptoStream(f, encryptor, CryptoStreamMode.Write))
                        {
                            c.Write(data, 0, data.Length);
                        }
                    }
                }
            }
        }
        //This Encrypts Any File [Not Folder]
        private static void EncryptFile(string inputFile, byte[] key, byte[] IV)
        {
            try
            {
                // Get the NonEncrypted File first and convert it to byte array
                byte[] file = File.ReadAllBytes(inputFile);
                // This is ONly when the AES encryption Algorithm is Selected
                using (SymmetricAlgorithm algorithm = Aes.Create())
                {
                    //algorithm.GenerateKey(); //Random Generate the Key
                    //algorithm.GenerateIV();//Random Generate the IV
                    using (ICryptoTransform crypto = algorithm.CreateEncryptor(key, IV))
                    {
                        // Encrypts/Overwrite the file
                        using (FileStream encryptFile = new FileStream(inputFile, FileMode.Create))
                        {
                            //After Encryption the data is rewritten back to the file
                            using (CryptoStream cryptoEncr = new CryptoStream(encryptFile, crypto, CryptoStreamMode.Write))
                            {
                                //Write/Overwrites the Encrypted data back to file
                                cryptoEncr.Write(file, 0, file.Length);
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        //This Decrypts Any File [Not Folder]
        private static void DecryptFile(string inputFile, byte[] key, byte[] IV)
        {
            try
            {
                // Get the Encrypted File first and convert it to byte array
                byte[] file = File.ReadAllBytes(inputFile);
                // This is ONly when the AES encryption Algorithm is Selected
                using (SymmetricAlgorithm algorithm = Aes.Create()) 
                {
                    // Validate that the key is correct and the document have not been tampered with, but it is impossible to tamper since the folder can't be access unless by the user.
                    using (ICryptoTransform decrypt = algorithm.CreateDecryptor(key, IV)) 
                    {
                        // Decrypts/Overwrite the file
                        using (FileStream decryptFile = new FileStream(inputFile, FileMode.Create))
                        {
                            //After decryption the data is rewritten back to the file
                            using (CryptoStream deEncr = new CryptoStream(decryptFile, decrypt, CryptoStreamMode.Write))
                            {
                                //Writes to the Files
                                deEncr.Write(file, 0, file.Length);
                            }
                        }
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        //Folder Hashing provides one-way encryption. This is ideal for storing passwords in a database, as you might never need (or want) to see a decrypted version.
        private byte[] HashedPassword(byte[] userFolder_pass)
        {
            byte[] hashedfolderpass = new byte[] { };
            switch(hashingCombo.Text)
            {
                case "MD5 (16)":
                    hashedfolderpass = MD5.Create().ComputeHash(userFolder_pass);
                    break;
                case "SHA-1 (20)":
                    hashedfolderpass = SHA1.Create().ComputeHash(userFolder_pass);
                    break;
                case "SHA-256 (32)":
                    hashedfolderpass = SHA256.Create().ComputeHash(userFolder_pass);
                    break;
                case "SHA-384 (48)":
                    hashedfolderpass = SHA384.Create().ComputeHash(userFolder_pass);
                    break;
                case "SHA-512 (64)":
                    hashedfolderpass = SHA512.Create().ComputeHash(userFolder_pass);
                    break;
                default:
                    hashedfolderpass = SHA384.Create().ComputeHash(userFolder_pass);
                    break;
            }
            return hashedfolderpass;
        }
        //GenerateRandom Password Button Click
        private void PassranBtn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello World");
            int index = 0;
            for (int a = 0; a < PasswordCombinations().Count; a++)
            {
                index = random.Next(a);// Picks a Random Password from the List 

            }
            password = PasswordCombinations().ElementAt(index);
            txtpassword.Text = password;
            txtpassconfirm.Text = password;
            randomPassChk.Checked = true;
        }
        //Lock Folder with the Hashed Password,
        private void LUnLockFolder (string adminUserName, string folderPath,bool lockFolder)
        {
            try
            {
                DirectorySecurity ds = Directory.GetAccessControl(folderPath);
                FileSystemAccessRule fsa = new FileSystemAccessRule(adminUserName, FileSystemRights.FullControl, AccessControlType.Deny);
                if(lockFolder)
                {
                    ds.AddAccessRule(fsa);
                }
                else
                {
                    ds.RemoveAccessRule(fsa);
                }
                
                Directory.SetAccessControl(folderPath, ds);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        //Generate a list of Random Passwords
        private List<string> PasswordCombinations()
        {
            //Generate a List of Random Password
            byte[] pass = new byte[16];

            RandomNumberGenerator rand = RandomNumberGenerator.Create();

            rand.GetBytes(pass);

            List<string> passCombinations = new List<string>();

            for (char c = 'A'; c <= 'Z'; c++)
            {
                foreach (byte ite in pass)
                {
                    passCombinations.Add(Convert.ToString(ite) + Convert.ToString(c) + Convert.ToString(random.Next(1, 27)) + Convert.ToString((c + 2)));
                }
            }
            return passCombinations;
        }

       
        //Get the Changes to Folder Made to the DataGrid
        private void metroGrid1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            while (e.ColumnIndex != 0 && e.ColumnIndex != 1 && e.ColumnIndex != 3 && e.ColumnIndex != 4 && e.ColumnIndex != 5)
            {
                string passwordChange = metroGrid1[e.ColumnIndex, e.RowIndex].Value.ToString();

                string fileName = metroGrid1[0, e.RowIndex].Value.ToString();

                foreach (FilesFolder folder in changingFiles)
                {
                    if (folder.Name.Equals(fileName))
                    {
                        folder.Password = passwordChange;
                        folder.Encrypted = true;
                        MessageBox.Show("Make sure to Click on \"Update Files Password\"After Making \"All Changes\" to Files \n Changed Password: " + passwordChange);
                    }
                }
                break;
            }
            metroGrid1.DataSource = changingFiles;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            metroGrid1.DataSource = changingFiles;
            MessageBox.Show("Updated Made to File System: Any More Changes to Password, if not Proceed to Encryption Options");
        }
    }
}
