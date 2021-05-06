using _07_StreamingContent_Repository.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_StreamingContent_Repository
{
    public class StreamingContentRepository
    {
        private readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();

        //CRUD(Create Read Update Delete) methods below
        //Create
        //Content
        public bool AddContentToDirectory(StreamingContent newContent)
        {
            int startingCount = _contentDirectory.Count;

            _contentDirectory.Add(newContent);

            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }
        //Movie
        public bool AddContentToDirectory(Movie newContent)
        {
            int startingCount = _contentDirectory.Count;

            _contentDirectory.Add(newContent);

            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }
        //Show

        //Episode

        //Read all
        //Content readl all
        public List<StreamingContent> GetContents()
        {
            return _contentDirectory;
        }

        //Movie Read all 
        public List<Movie> GetMovies()
        {
            //initialize empty list
            List<Movie> allMovies = new List<Movie>();
            //Look through our directory
            foreach(StreamingContent content in _contentDirectory)
            {
                //check if object is a Movie class
                if (content is Movie)
                {
                    //Load into our list
                    allMovies.Add((Movie)content);
                }
            }
            //Return out list
            return allMovies;
        }
        //show read all
        public List<Show> GetShows()
        {
            //setup our lsit
            List<Show> allShows = new List<Show>();
            //find our shows
            foreach(StreamingContent content in _contentDirectory)
            {
                //Check that it is a show
                if (content.GetType() == typeof(Show))
                {
                    //yes? add to the list
                    allShows.Add((Show)content);
                }
            }
            //give shows back
            return allShows;
        }



        // episode read all

        //gwt by title 
        //content

        public StreamingContent GetContentByTitle(string title)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower() == title.ToLower())
                {
                    return content;
                }
            }
            return null;
        }

        //movie
        public Movie GetMovieByTitle(string title)
        {
            foreach(StreamingContent movie in _contentDirectory)
            {                                     //Using is to make sure movie 'is' of class type Movie 
                if(movie.Title.ToLower() == title.ToLower() && movie is Movie)
                {
                    return (Movie)movie;  //return movie as Movie; ---- Using 'as' as a way to cast
                }
            }

            return null;
        }

        //show
        //getshowbytitle
        //Accesor // Return Type // Name (Parameters)
        public Show GetShowByTitle(string title)
        {
            foreach (StreamingContent show in _contentDirectory)
            {
                if (show.Title.ToLower() == title.ToLower() && show.GetType() == typeof(Show))
                {
                    return (Show)show;
                }
            }
            return null;
        }
        //episode

        public bool UpdateExistingContent(string originalTitle, StreamingContent newContentValues)
        {
            StreamingContent oldContent = GetContentByTitle(originalTitle);

            if(oldContent != null)
            {
                oldContent.Title = newContentValues.Title;
                oldContent.Description = newContentValues.Description;
                oldContent.StarRating = newContentValues.StarRating;
                oldContent.TypeOfGenre = newContentValues.TypeOfGenre;
                oldContent.MaturityRating = newContentValues.MaturityRating;

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteExistingContent(string titleToDelete)
        {
            StreamingContent contentToDelete = GetContentByTitle(titleToDelete);
            if(contentToDelete == null)
            {
                return false;
            }
            else
            {
                _contentDirectory.Remove(contentToDelete);
                return true;
            }
        }
    }
}
