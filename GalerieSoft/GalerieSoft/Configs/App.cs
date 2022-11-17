using GalerieSoft.Configs;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fortuna_soft.config
{
    public class App
    {
        /// <summary>
        /// Function to create config directory to the disc C
        /// </summary>
        public void createConfigDatabaseDirectory()
        {
            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(Constants.InitialDirectory);
                if (!Directory.Exists(Constants.InitialDirectory))
                {
                    Directory.CreateDirectory(Constants.InitialDirectory);
                    dirInfo.Attributes = FileAttributes.Hidden;
                }
                dirInfo.Attributes = FileAttributes.Hidden;
            }
            catch (Exception exc)
            {
                throw new Exception("Error while creating " + Constants.InitialDirectory + "Directory" + exc.Message);
            }
        }

        public void CheckFilesDB()
        {
            try
            {
                if (!File.Exists(Constants.dbName))
                {
                    var dbName = File.Create(Constants.dbName);
                    dbName.Close();
                    if (!File.Exists(Constants.ServerUsername))
                    {
                        var ServerUsername = File.Create(Constants.ServerUsername);
                        ServerUsername.Close();
                        if (!File.Exists(Constants.SeverPassWord))
                        {
                            var SeverPassWord = File.Create(Constants.SeverPassWord);
                            SeverPassWord.Close();
                            if (!File.Exists(Constants.Server))
                            {
                                var Server = File.Create(Constants.Server);
                                Server.Close();
                            }
                        }
                    }
                }
                else if (!File.Exists(Constants.ServerUsername))
                {
                    var ServerUsername = File.Create(Constants.ServerUsername);
                    ServerUsername.Close();
                    if (!File.Exists(Constants.SeverPassWord))
                    {
                        var SeverPassWord = File.Create(Constants.SeverPassWord);
                        SeverPassWord.Close();
                        if (!File.Exists(Constants.Server))
                        {
                            var Server = File.Create(Constants.Server);
                            Server.Close();
                        }
                    }
                }
                else if (!File.Exists(Constants.SeverPassWord))
                {
                    var SeverPassWord = File.Create(Constants.SeverPassWord);
                    SeverPassWord.Close();
                    if (!File.Exists(Constants.Server))
                    {
                        var Server = File.Create(Constants.Server);
                        Server.Close();
                    }
                }
                else if (!File.Exists(Constants.Server))
                {
                    var Server = File.Create(Constants.Server);
                    Server.Close();
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        /// <summary>
        /// this function can be used to check if files exists
        /// </summary>
        /// <returns></returns>
        public bool CheckIfFileExits()
        {
            try
            {
                if (!File.Exists(Constants.dbName) || !File.Exists(Constants.ServerUsername) || !File.Exists(Constants.SeverPassWord) ||
                    !File.Exists(Constants.Server))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void RwiteInFilesDB(TextBox server, TextBox dbname, TextBox username, TextBox password)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(Constants.Server, append: false))
                {
                    //File.WriteAllText(Constantes.Server, server.Text);
                    sw.WriteLineAsync(server.Text);
                    sw.Flush();
                    sw.Dispose(); //Appel le destructeur du StreamReader
                }

                using (StreamWriter sw = new StreamWriter(Constants.dbName, append: false))
                {
                    // File.WriteAllText(Constantes.dbName, dbname.Text);
                    sw.WriteLineAsync(dbname.Text);
                    sw.Flush();
                    sw.Dispose(); //Appel le destructeur du StreamReader
                }

                using (StreamWriter sw = new StreamWriter(Constants.ServerUsername, append: false))
                {
                    // File.WriteAllText(Constantes.ServerUsername, username.Text);
                    sw.WriteLineAsync(username.Text);
                    sw.Flush();
                    sw.Dispose(); //Appel le destructeur du StreamReader
                }


                using (StreamWriter sw = new StreamWriter(Constants.SeverPassWord, append: false))
                {
                    // File.WriteAllText(Constantes.SeverPassWord, password.Text);
                    sw.WriteLineAsync(password.Text);
                    sw.Flush();
                    sw.Dispose(); //Appel le destructeur du StreamReader
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
