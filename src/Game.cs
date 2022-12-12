using DDLC_ModManager.Properties;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDLC_ModManager.src
{
    public static class Games
    {
        public static Game INSTANCE = new Game();
        public static Game DokiDokiLiteratureClub = new Game()
        {
            GAME_NAME = "DokiDokiLiteratureClub",
        };

        public class Game
        {
            public string GAME_NAME = "NULL";
            public string EXE_NAME = string.Empty;
        }
    }
}