using System;
using System.Collections.Generic;
using System.IO;
using CsvHelper;
using System.Linq;
using System.Globalization;

namespace BDSA2020.Assignment02
{
    public class Wizard
    {
        public string Name { get; set; }

        // Book or film or...
        public string Medium { get; set; }

        public int? Year { get; set; }

        public string Creator { get; set; }

        public static Lazy<IReadOnlyCollection<Wizard>> Wizards { get; } = new Lazy<IReadOnlyCollection<Wizard>>(() =>
        {
            var csv = File.OpenText("../../../../Wizards.csv");
            using var reader = new CsvReader(csv, CultureInfo.InvariantCulture);
            return reader.GetRecords<Wizard>().ToList().AsReadOnly();
        });


        public IEnumerable<string> getRowlingWizards(){
            IEnumerable<string> r = Wizards.Value .Where(h => h.Creator.Contains("Rowling")).Select(h => h.Name);
            return r;
        } 

        public int? getFirstYearDarth(){
            Wizard w = Wizards.Value.Where(h => h.Name.Contains("Darth")).OrderBy(h => h.Year).First();
            return w.Year;
        } 

        public IEnumerable<(string,int?)> getHarryPotters(){
            IEnumerable<(string,int?)> w = Wizards.Value.Where(h => h.Medium.Contains("Harry Potter")).Select(h => (h.Name, h.Year));
            return w;
        } 

        public IEnumerable<string> getWizardNames(){
            IEnumerable<string> w = Wizards.Value.GroupBy(h => h.Creator).OrderByDescending(h => h.Key).Thenby(h => h.Name).Select(h => h.Name);
            return w;
        } 
        
        
    }

}
