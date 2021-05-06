using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_StreamingContent_Repository
{
    public enum GenreType { Horror = 1, RomCom, SciFi, Documentary, Romance, Drama, Action, Comedy, Anime}
    public enum MaturityRating { G = 1, PG, PG_13, R, TV_G, TV_PG, TV_14, TV_MA}
    public class StreamingContent
    {
        //POCO - PLain Old CSharp Object

        public string Title { get; set; }
        public string Description { get; set; }
        public double StarRating { get; set; }
        public GenreType TypeOfGenre { get; set; }
        public MaturityRating MaturityRating { get; set; }
        public bool IsFamilyFriendly 
        { 
            get 
            {
                if (MaturityRating == MaturityRating.R || MaturityRating == MaturityRating.TV_MA)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        public StreamingContent() { }

        public StreamingContent(string title, string description, double starRating, GenreType typeOfGenre, MaturityRating maturityRating)
        {
            Title = title;
            Description = description;
            StarRating = starRating;
            TypeOfGenre = typeOfGenre;
            MaturityRating = maturityRating;
        }
    }
}
