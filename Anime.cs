using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog124_Practic_Classes
{
    internal class Anime
    {
        string _name;
        string _releaseDate;
        int _rateing;
        string _favoriteCharacter;

        public Anime(string name, string releaseDate, int rateing, string favoriteCharacter)
        {
            Name = name;
            ReleaseDate = releaseDate;
            Rateing = rateing;
            FavoriteCharacter = favoriteCharacter;
        }

        public string Name { get => _name; set => _name = value; }
        public string ReleaseDate { get => _releaseDate; set => _releaseDate = value; }
        public int Rateing { get => _rateing; set => _rateing = value; }
        public string FavoriteCharacter { get => _favoriteCharacter; set => _favoriteCharacter = value; }
    }
}
