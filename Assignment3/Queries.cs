using System;
using System.Collections.Generic;
using System.IO;
using CsvHelper;
using System.Linq;
using System.Globalization;

namespace BDSA2020.Assignment3
{
    public static class Queries
    {
        public static IEnumerable<string> getRowlingWizards(this IEnumerable<Wizard> wizards){
            IEnumerable<string> r = wizards.Where(h => h.Creator.Contains("Rowling")).Select(h => h.Name);
            foreach(string name in r){
                yield return name;
            }
        } 

        public static int? getFirstYearDarth(this IEnumerable<Wizard> wizards){
            Wizard w = wizards.Where(h => h.Name.Contains("Darth")).OrderBy(h => h.Year).First();
            return w.Year;
        } 

        public static IEnumerable<(string,int?)> getHarryPotters(this IEnumerable<Wizard> wizards){
            IEnumerable<(string,int?)> w = wizards.Where(h => h.Medium.Contains("Harry Potter")).Select(h => (h.Name, h.Year));
            foreach(var tuple in w){
                yield return tuple;
            }
        } 
    
       public static IEnumerable<string> getWizardNames(this IEnumerable<Wizard> wizards){
            IEnumerable<string> w = wizards
            .GroupBy(h => new {h.Creator, h.Name})
            .OrderByDescending(h => h.Key.Creator)
            .ThenBy(h => h.Key.Name)
            .Select(h => h.Key.Name);
    

            foreach(string name in w){
                yield return name;
            }
        } 

         public static IEnumerable<string> getRowlingWizardsLinq(IEnumerable<Wizard> wizards){
            IEnumerable<string> r =
            from w in wizards
            where w.Creator.Contains("Rowling")
            select w.Name;
    
            foreach(string name in r){
                yield return name;
            }
        } 

        public static int? getFirstYearDarthLinq(IEnumerable<Wizard> wizards){
            IEnumerable<int?> w =
            from wiz in wizards
            where wiz.Name.Contains("Darth")
            orderby wiz.Year
            select wiz.Year;
            
            return w.First();
        } 

        public static IEnumerable<(string,int?)> getHarryPottersLinq(IEnumerable<Wizard> wizards){
            IEnumerable<(string,int?)> w =
            from wiz in wizards 
            where wiz.Medium.Contains("Harry Potter")
            select (wiz.Name,wiz.Year);

            foreach(var tuple in w){
                yield return tuple;
            }
        } 

        public static IEnumerable<string> getWizardNamesLinq(IEnumerable<Wizard> wizards){
            IEnumerable<string> w =
            from wiz in wizards
            group wiz by (wiz.Creator,wiz.Name) into g
            orderby g.Key.Creator descending,
            g.Key.Name
            select g.Key.Name;
            
            foreach(string name in w){
                yield return name;
            }
        }
    }
}
