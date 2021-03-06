﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace HeroWarsGame
{
    class Save
    {
        public List<string> _heroes = new List<string>();

        public List<string> Heroes
        {
            get { return _heroes; }
            set { _heroes.Add(value.ToString()); }

        }
        public void AddNames()
        {
            using (StreamReader readNames = File.OpenText(@"D:\\HeroWarsSaves.txt"))
            {
                while (!readNames.EndOfStream)
                {
                    string line = readNames.ReadLine();
                    string[] info = line.Split(',');

                    _heroes.Add(info[0]);
                }
            }
            SaveHeroName(_heroes);

        }
        public void RefreshCharNames()
        {
            File.Delete(@"D:\\Names.txt");
            _heroes.Clear();
            AddNames();
        }
        public void UpdateCurFile(string charLine)
        {
            File.Delete(@"D:\\CurrentChar.txt");

            FileStream file = new FileStream(@"D:\\CurrentChar.txt", FileMode.Create, FileAccess.ReadWrite);
            byte[] lineBytes = Encoding.UTF8.GetBytes(charLine);
            file.Write(lineBytes, 0, lineBytes.Length);
            file.Close();
        }
        public void UpdateSaved()
        {
            string currentchar = "";
            string currcharName = "";

            string PrevCharName = "";
            string OldChar = "";

            using (StreamReader GetCurChar = File.OpenText(@"D:\\CurrentChar.txt"))
            {
                currentchar = GetCurChar.ReadLine();
                string[] NameGet = currentchar.Split(',');
                currcharName = NameGet[0].ToString();
            }
            using (StreamReader HeroFile = File.OpenText(@"D:\\HeroWarsSaves.txt"))
            {
                using (FileStream NewHeroFile = new FileStream(@"D:\\HeroWarsTempSaves.txt", FileMode.Create, FileAccess.ReadWrite))
                {
                    StreamWriter Overwriter = new StreamWriter(NewHeroFile);
                    while (!HeroFile.EndOfStream)
                    {
                         OldChar = HeroFile.ReadLine();
                        string[] CharInfo = OldChar.Split(',');
                         PrevCharName = (CharInfo[0]).ToString();

                        if (currcharName != PrevCharName)
                            Overwriter.WriteLine(OldChar);
                        else
                            Overwriter.WriteLine(currentchar);
                    }

                    Overwriter.Close();

                }
            }


            File.Delete(@"D:\\HeroWarsSaves.txt");
            File.Move(@"D:\\HeroWarsTempSaves.txt", @"D:\\HeroWarsSaves.txt");
        }
        public void DeleteChar(string characterNameToDelete)
        {
            using (StreamReader HeroFile = File.OpenText(@"D:\\HeroWarsSaves.txt"))
            {
                using (FileStream NewHeroFile = new FileStream(@"D:\\HeroWarsTempSaves.txt", FileMode.Create, FileAccess.ReadWrite))
                {
                    StreamWriter Overwriter = new StreamWriter(NewHeroFile);
                    while (!HeroFile.EndOfStream)
                    {
                        string SavedCharLine = HeroFile.ReadLine();
                        string[] CharInfo = SavedCharLine.Split(',');
                        string characterName = (CharInfo[0]).ToString();

                        if (characterNameToDelete != characterName)
                            Overwriter.WriteLine(SavedCharLine);
                    }

                    Overwriter.Close();

                }
            }


            File.Delete(@"D:\\HeroWarsSaves.txt");
            File.Move(@"D:\\HeroWarsTempSaves.txt", @"D:\\HeroWarsSaves.txt");
        }
        public void QuitGame()
        {
            UpdateSaved();
            File.Delete(@"D:\\CurrentChar.txt");
            File.Delete(@"D:\\Names.txt");
        }
        
        public void SaveHeroName (List<string> _heroes)
        {
            using (FileStream names = File.Open(@"D:\\Names.txt", FileMode.Append, FileAccess.Write))
            {

                foreach (var n in _heroes)
                {
                    byte[] lineBytes = Encoding.UTF8.GetBytes(n.ToString());
                    names.Write(lineBytes, 0, lineBytes.Length);
                    string newLine = "\n";
                    byte[] newLineBytes = Encoding.UTF8.GetBytes(newLine);
                    names.Write(newLineBytes, 0, newLine.Length);
                }
                names.Close();
            }
        }

           
    }
}
