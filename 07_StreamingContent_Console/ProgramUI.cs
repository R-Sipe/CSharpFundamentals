using _07_StreamingContent_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_StreamingContent_Console
{
    public class ProgramUI
    {
        private StreamingContentRepository _repo = new StreamingContentRepository();
        public void Run()
        {
            SeedContentList();
            Menu();
        }

        private void Menu()
        {
            bool keepRunning = true;
            while (keepRunning)
            {

                Console.WriteLine("Select a menu option:\n" +
                    "1. Create New Content\n" +
                    "2. View All Content\n" +
                    "3. View Content By Title\n" +
                    "4. Update Existing Content\n" +
                    "5. Delete Existing Content\n" +
                    "6. Exit");

                string input = Console.ReadLine();

                switch (input.ToLower())
                {
                    case "1":
                    case "one":
                        //CreateNewContent
                        CreateNewContent();
                        break;
                    case "2":
                    case "two":
                        //View all content
                        DisplayAllContent();
                        break;
                    case "3":
                    case "three":
                        //view content by title
                        DisplayContentByTitle();
                        break;
                    case "4":
                    case "four":
                        //Update existing content
                        UpdateContent();
                        break;
                    case "5":
                    case "five":
                        //Delete existing content
                        DeleteContent();
                        break;
                    case "6":
                    case "six":
                        //Exit
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("You're throwing, type a valid number");
                        break;
                }
                Console.WriteLine("Please press any key to continue");
                Console.ReadKey();
                Console.Clear();
            }

        }
        private void CreateNewContent()
        {
            Console.Clear();
            StreamingContent newContent = new StreamingContent();

            //Title
            Console.WriteLine("What is the title for this content?");
            newContent.Title = Console.ReadLine();

            //Description
            Console.WriteLine("Enter the description of the content");
            newContent.Description = Console.ReadLine();

            //Star rating
            Console.WriteLine("Enter the star rating for this content (0.0 - 5.0)");
            string starRatingAsString = Console.ReadLine();
            double starRatingAsDouble = Convert.ToDouble(starRatingAsString);
            newContent.StarRating = starRatingAsDouble;

            //newContent.StarRating = Convert.ToDouble(Console.ReadLine()); ---- This is one line same as above 

            //Genre
            Console.WriteLine("Enter the Genre number for this content:\n" +
                "1. Horror\n" +
                "2. RomCom\n" +
                "3. Scifi\n" +
                "4. Documentary\n" +
                "5. Romance\n" +
                "6. Drama\n" +
                "7. Action\n" +
                "8. Comedy\n" +
                "9. Anime");

            string genreAsString = Console.ReadLine();
            int genreAsInt = Convert.ToInt32(genreAsString);
            newContent.TypeOfGenre = (GenreType)genreAsInt;

            //Maturity Rating
            Console.WriteLine("Enter the Maturity Rating for this content\n" +
                "1. G\n" +
                "2. PG\n" +
                "3. PG_13\n" +
                "4. R\n" +
                "5. TV_G\n" +
                "6. TV_PG\n" +
                "7. TV_14\n" +
                "8. TV_MA");

            string maturityRatingAsString = Console.ReadLine();
            int maturityAsInt = Convert.ToInt32(maturityRatingAsString);
            newContent.MaturityRating = (MaturityRating)maturityAsInt;
            bool wasAddedCorrectly = _repo.AddContentToDirectory(newContent);
            if (wasAddedCorrectly)
            {
                Console.WriteLine("The content was added correctly");
            }
            else
            {
                Console.WriteLine("Could not add the content");
            }

            //Same as string jsut one line
            //newContent.MaturityRating = (MaturityRating)Convert.ToInt32(Console.ReadLine());

        }

        private void DisplayAllContent() //Display all content in the directory
        {
            Console.Clear();
            List<StreamingContent> allContent = _repo.GetContents();
            foreach(StreamingContent content in allContent)
            {
                Console.ForegroundColor=ConsoleColor.Green;
                Console.WriteLine($"Title: {content.Title}\n" +
                    $"Is Family Friendly: {content.IsFamilyFriendly}");
                Console.ResetColor();
            }
        }

        private void DisplayContentByTitle()
        {
            Console.Clear();
            DisplayAllContent();

            Console.WriteLine("What title do you want to see?");
            StreamingContent displayContent = _repo.GetContentByTitle(Console.ReadLine());
           
            if (displayContent != null)
            {
                Console.WriteLine($"Title: {displayContent.Title}\n" +
                    $"Description: {displayContent.Description}\n" +
                    $"Star Rating: {displayContent.StarRating}\n" +
                    $"Type of Genre: {displayContent.TypeOfGenre}\n" +
                    $"Maturity Rating: {displayContent.MaturityRating}\n" +
                    $"Is Family Friendly: {displayContent.IsFamilyFriendly}");
            }
            else
            {
                Console.WriteLine("There isn't content by that title.");
            }
        }

        private void UpdateContent()
        {
            Console.Clear();
            DisplayAllContent();
            Console.WriteLine("Enter the title of the content you would like to update");

            string oldTitle = Console.ReadLine();

            StreamingContent newContent = new StreamingContent();

            //Title
            Console.WriteLine("What is the new title for this content?");
            newContent.Title = Console.ReadLine();

            //Description
            Console.WriteLine("Enter the new description of the content");
            newContent.Description = Console.ReadLine();

            //Star rating
            Console.WriteLine("Enter the new star rating for this content (0.0 - 5.0)");
            string starRatingAsString = Console.ReadLine();
            double starRatingAsDouble = Convert.ToDouble(starRatingAsString);
            newContent.StarRating = starRatingAsDouble;

            //newContent.StarRating = Convert.ToDouble(Console.ReadLine()); ---- This is one line same as above 

            //Genre
            Console.WriteLine("Enter the new Genre number for this content:\n" +
                "1. Horror\n" +
                "2. RomCom\n" +
                "3. Scifi\n" +
                "4. Documentary\n" +
                "5. Romance\n" +
                "6. Drama\n" +
                "7. Action\n" +
                "8. Comedy\n" +
                "9. Anime");

            string genreAsString = Console.ReadLine();
            int genreAsInt = Convert.ToInt32(genreAsString);
            newContent.TypeOfGenre = (GenreType)genreAsInt;

            //Maturity Rating
            Console.WriteLine("Enter the new Maturity Rating for this content\n" +
                "1. G\n" +
                "2. PG\n" +
                "3. PG_13\n" +
                "4. R\n" +
                "5. TV_G\n" +
                "6. TV_PG\n" +
                "7. TV_14\n" +
                "8. TV_MA");

            string maturityRatingAsString = Console.ReadLine();
            int maturityAsInt = Convert.ToInt32(maturityRatingAsString);

            bool wasUpdated = _repo.UpdateExistingContent(oldTitle, newContent);
            if (wasUpdated)
            {
                Console.WriteLine("The content was updated successfully");
            }
            else
            {
                Console.WriteLine("Not content by that title exists");
            }
        }

        private void DeleteContent()
        {
            Console.Clear();
            DisplayAllContent();

            Console.WriteLine("Enter the title or content you want to delete");

            bool wasDeleted = _repo.DeleteExistingContent(Console.ReadLine());
            if (wasDeleted)
            {
                Console.WriteLine("Your content was successfully deleted");
            }
            else
            {
                Console.WriteLine("LOL you couldnt delete it loser");
            }
        }

        private void SeedContentList()
        {
            StreamingContent future = new StreamingContent("Back to the Future", "Marty gets shot", 4.5, GenreType.SciFi, MaturityRating.PG);
            StreamingContent starWars = new StreamingContent("Star Wars", "Jar Jar saves the world", 5, GenreType.SciFi, MaturityRating.PG);
            StreamingContent rubber = new StreamingContent("Rubber", "Car tire weird movie tbh", 1.5, GenreType.SciFi, MaturityRating.PG);

            _repo.AddContentToDirectory(future);
            _repo.AddContentToDirectory(starWars);
            _repo.AddContentToDirectory(rubber);
        }
    }
}
