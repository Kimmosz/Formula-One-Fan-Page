using FormulaOneFanPage.Models;
using System;
using System.Linq;

namespace FormulaOneFanPage.Data {
    public static class DbInitializer {
        public static void Initialize(MainContext context) {
            //context.Database.EnsureCreated();

            // Look for any Drivers
            if (context.Drivers.Any()) {
                return;
            }

            // Add Drivers to Database
            var drivers = new Driver[] {
                new Driver{FirstName="Max", LastName="Verstappen", BirthDate=DateTime.Parse("1997-09-30"), Nationality="The Netherlands", DriverNumber=1, TeamId=1, Description="TBA", Championships=1},
                new Driver{FirstName="Lewis", LastName="Hamilton", BirthDate=DateTime.Parse("1985-01-07"), Nationality="United Kingdom", DriverNumber=44, TeamId=2, Description="TBA", Championships=7},
                new Driver{FirstName="Daniel", LastName="Ricciardo", BirthDate=DateTime.Parse("1989-07-01"), Nationality="Australia", DriverNumber=3, TeamId=3, Description="TBA", Championships=0},
                new Driver{FirstName="Pierre", LastName="Gasly", BirthDate=DateTime.Parse("1996-02-07"), Nationality="France", DriverNumber=10, TeamId=4, Description="TBA", Championships=0}
            };

            foreach (Driver driver in drivers) {
                context.Drivers.Add(driver);
            }
            context.SaveChanges();

            // Look for any Teams
            if (context.Teams.Any()) {
                return;
            }

            // Add Teams to Database
            var teams = new Team[] {
                new Team{Name="Oracle Red Bull Racing", Description="TBA", Championships=4},
                new Team{Name="Mercedes-AMG Petronas", Description="TBA", Championships=8},
                new Team{Name="McLaren", Description="TBA", Championships=8},
                new Team{Name="Scuderia AlphaTauri", Description="TBA", Championships=0}
            };

            foreach (Team team in teams) {
                context.Teams.Add(team);
            }
            context.SaveChanges();


        }
    }
}
