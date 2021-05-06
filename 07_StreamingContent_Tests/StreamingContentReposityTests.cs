using _07_StreamingContent_Repository;
using _07_StreamingContent_Repository.Content;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _07_StreamingContent_Tests
{
    [TestClass]
    public class StreamingContentReposityTests
    {
        [TestMethod]
        public void AddToDirectory_ShouldGetCorrectBoolean()
        {
            //AAA - Arrange Act Assert
            //Arrange
            StreamingContent content = new StreamingContent();
            StreamingContentRepository repository = new StreamingContentRepository();

            //Act
            bool addResult = repository.AddContentToDirectory(content);

            //Assert
            Assert.IsTrue(addResult);
        }

        [TestMethod]
        public void GetDirectory_ShouldReturnCorrectCollection()
        {
            //Arrange
            StreamingContent content = new StreamingContent();
            StreamingContentRepository repository = new StreamingContentRepository();
            repository.AddContentToDirectory(content);

            //Act
            List<StreamingContent> directory = repository.GetContents();

            //Assert
            bool directoryHasContent = directory.Contains(content);
            Assert.IsTrue(directoryHasContent);
        }

        private StreamingContent _content;
        private StreamingContentRepository _repo;

        [TestInitialize]
        public void Arrange()
        {
            _repo = new StreamingContentRepository();
            _content = new StreamingContent("Back to the Future", "A high school student named Marty get accidentally sent back in time 30 years", 4.4, GenreType.SciFi, MaturityRating.PG);
            _repo.AddContentToDirectory(_content);
        }

        [TestMethod]
        public void CheckMovieRunTime()
        {
            //create a movie type, using full constructor and inherited base
            Movie joe = new Movie("Joe Dirt", "Crazy guy with a mullet", 3.2, GenreType.Romance, MaturityRating.PG_13, 112);
            //creating a list to replicate our repo
            List<StreamingContent> miniRepo = new List<StreamingContent>();
            miniRepo.Add(joe);

            //filtering our repo by Movies in our foreach
            foreach (Movie content in miniRepo)
            {
                Console.WriteLine(content.RunTime);
            }

            //searching for StreamingContent makes run time unavaliable without casting
            foreach (StreamingContent content in miniRepo)
            {
                //finding movie types
                if (content is Movie)
                {
                    //setting content as Movie to access Movie exclusive properties
                    Console.WriteLine((content as Movie).RunTime);
                }
            }
        }

        [TestMethod]
        public void GetByTitle_SHouldReturnCorrectContent()
        {
            //Arrange
            //Done in Arrange() method

            //Act
            StreamingContent searchResult = _repo.GetContentByTitle("Back to the Future");

            //Assert
            Assert.AreEqual(_content, searchResult);
        }

        [TestMethod]
        public void UpdateExistingContent_ShouldTurnUpdatedValue()
        {
            //arrange
            //already done in arrange() method

            //act
            _repo.UpdateExistingContent("Back to the Future", new StreamingContent("Back to the Future 2", "Marty goes into the future 30 years", 4.0, GenreType.SciFi, MaturityRating.PG_13));

            //assert
            Assert.AreEqual(_content.Title, "Back to the Future 2");
        }

        [TestMethod]
        public void DeleteExistingContent_ShouldReturnTrue()
        {
            bool wasDeleted = _repo.DeleteExistingContent("Back to the Future");

            Assert.IsTrue(wasDeleted);
        }
    }
}
