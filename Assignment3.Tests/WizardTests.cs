using Xunit;
using System.Collections.Generic;
using System.Linq; 

namespace BDSA2020.Assignment3.Tests
{
    public class WizardTests
    {
        [Fact]
        public void Wizards_contains_12_wizards()
        {
            var wizards = Wizard.Wizards.Value;

            Assert.Equal(12, wizards.Count);
        }

        [Theory]
        [InlineData("Darth Vader", "Star Wars", 1977, "George Lucas")]
        [InlineData("Sauron", "The Fellowship of the Ring", 1954, "J.R.R. Tolkien")]
        public void Spot_check_wizards(string name, string medium, int year, string creator)
        {
            var wizards = Wizard.Wizards.Value;

            Assert.Contains(wizards, w =>
                w.Name == name &&
                w.Medium == medium &&
                w.Year == year &&
                w.Creator == creator
            );
        }

        [Fact]
        public void Given_Wizards_Return_Creator_Rowling()
        {
            //Arrange
            IEnumerable<Wizard> input = Wizard.Wizards.Value;
            
            //Act
            var output = input.getRowlingWizards();

            //Assert

            Assert.Contains("Seamus Finnigan",output);
            Assert.Contains("Dean Thomas",output);
            Assert.Contains("Ginny Weasley",output);
            Assert.Contains("Fred Weasley",output);
            Assert.Contains("Ronald Weasley",output);
            Assert.Contains("Neville Longbottom",output);
            Assert.Contains("Albus Dumbledore",output);
            Assert.Contains("Hermione Granger",output);
            Assert.Contains("Harry Potter",output);
            Assert.Equal(9,output.Count());
        }

        [Fact]
        public void Given_Wizards_Return_First_Darth()
        {
            //Arrange
            IEnumerable<Wizard> input = Wizard.Wizards.Value;
            
            //Act
            int? output = input.getFirstYearDarth();

            //Assert
            Assert.Equal(1977,output);
        }

        [Fact]
        public void Given_Wizards_Return_Medium_HarryPotter()
        {
            //Arrange
            IEnumerable<Wizard> input = Wizard.Wizards.Value;
            
            //Act
            var output = input.getHarryPotters();

            //Assert

            Assert.Contains(("Seamus Finnigan",1997),output);
            Assert.Contains(("Dean Thomas",1997),output);
            Assert.Contains(("Ginny Weasley",1997),output);
            Assert.Contains(("Fred Weasley",1997),output);
            Assert.Contains(("Ronald Weasley",1997),output);
            Assert.Contains(("Neville Longbottom",1997),output);
            Assert.Contains(("Albus Dumbledore",1997),output);
            Assert.Contains(("Hermione Granger",1997),output);
            Assert.Contains(("Harry Potter",1997),output);
            Assert.Equal(9,output.Count());
        }
/*
        [Fact]
        public void Given_Wizards_Return_Names_Groupedby_Creator_ordered()
        {
            //Arrange
            IEnumerable<Wizard> input = Wizard.Wizards.Value;
            
            //Act
            var output = input.getWizardNames();

            //Assert
            Assert.Equal("Sauron",output.ElementAt(0));
            Assert.Equal("Albus Dumbledore",output.ElementAt(1));
            Assert.Equal("Dean Thomas",output.ElementAt(2));
            Assert.Equal("Fred Weasley",output.ElementAt(3));
            Assert.Equal("Ginny Weasley",output.ElementAt(4));
            Assert.Equal("Harry Potter",output.ElementAt(5));
            Assert.Equal("Hermione Granger",output.ElementAt(6));
            Assert.Equal("Neville Longbottom",output.ElementAt(7));
            Assert.Equal("Ronald Weasley",output.ElementAt(8));
            Assert.Equal("Seamus Finnigan",output.ElementAt(9));
            Assert.Equal("Darth D",output.ElementAt(10));
            Assert.Equal("Darth Vader",output.ElementAt(11));
            Assert.Equal(12,output.Count());
        }*/

        [Fact]
        public void Given_Wizards_Return_Creator_Rowling_Linq()
        {
            //Arrange
            IEnumerable<Wizard> input = Wizard.Wizards.Value;
            
            //Act
            var output = Queries.getRowlingWizardsLinq(input);

            //Assert
            Assert.Contains("Seamus Finnigan",output);
            Assert.Contains("Dean Thomas",output);
            Assert.Contains("Ginny Weasley",output);
            Assert.Contains("Fred Weasley",output);
            Assert.Contains("Ronald Weasley",output);
            Assert.Contains("Neville Longbottom",output);
            Assert.Contains("Albus Dumbledore",output);
            Assert.Contains("Hermione Granger",output);
            Assert.Contains("Harry Potter",output);
            Assert.Equal(9,output.Count());
        }

        [Fact]
        public void Given_Wizards_Return_First_Darth_Linq()
        {
            //Arrange
            IEnumerable<Wizard> input = Wizard.Wizards.Value;
            
            //Act
            int? output = Queries.getFirstYearDarthLinq(input);

            //Assert
            Assert.Equal(1977,output);
        }

        [Fact]
        public void Given_Wizards_Return_Medium_HarryPotter_Linq()
        {
            //Arrange
            IEnumerable<Wizard> input = Wizard.Wizards.Value;
            
            //Act
            var output = Queries.getHarryPottersLinq(input);

            //Assert

            Assert.Contains(("Seamus Finnigan",1997),output);
            Assert.Contains(("Dean Thomas",1997),output);
            Assert.Contains(("Ginny Weasley",1997),output);
            Assert.Contains(("Fred Weasley",1997),output);
            Assert.Contains(("Ronald Weasley",1997),output);
            Assert.Contains(("Neville Longbottom",1997),output);
            Assert.Contains(("Albus Dumbledore",1997),output);
            Assert.Contains(("Hermione Granger",1997),output);
            Assert.Contains(("Harry Potter",1997),output);
            Assert.Equal(9,output.Count());
        }
/*
        [Fact]
        public void Given_Wizards_Return_Names_Groupedby_Creator_ordered_Linq()
        {
            //Arrange
            IEnumerable<Wizard> input = Wizard.Wizards.Value;
            
            //Act
            var output = Queries.getWizardNamesLinq(input);

            //Assert
            Assert.Equal("Sauron",output.ElementAt(0));
            Assert.Equal("Albus Dumbledore",output.ElementAt(1));
            Assert.Equal("Dean Thomas",output.ElementAt(2));
            Assert.Equal("Fred Weasley",output.ElementAt(3));
            Assert.Equal("Ginny Weasley",output.ElementAt(4));
            Assert.Equal("Harry Potter",output.ElementAt(5));
            Assert.Equal("Hermione Granger",output.ElementAt(6));
            Assert.Equal("Neville Longbottom",output.ElementAt(7));
            Assert.Equal("Ronald Weasley",output.ElementAt(8));
            Assert.Equal("Seamus Finnigan",output.ElementAt(9));
            Assert.Equal("Darth D",output.ElementAt(10));
            Assert.Equal("Darth Vader",output.ElementAt(11));
            Assert.Equal(12,output.Count());
        }*/
    }
}

