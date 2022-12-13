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

        public static Game DokiDokiLiteratureClub_Plus = new Game()
        {
            GAME_NAME = "DokiDokiLiteratureClub_Plus",
        };

        public static IEnumerable<Game> SUPPORTED_GAMES()
        {
            yield return DokiDokiLiteratureClub;
            yield return DokiDokiLiteratureClub_Plus;
        }

        public class Game
        {
            public string GAME_NAME = "NULL";
            public string EXE_NAME = string.Empty;
            public Int32 DIRECT_X_VER = Int32.MaxValue;
            public string[] FOLDERS = {"raw"};

            public override string ToString()
            {
                return GAME_NAME;
            }
        }
    }
}
