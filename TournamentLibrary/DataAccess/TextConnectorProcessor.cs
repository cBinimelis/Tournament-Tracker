﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using TournamentLibrary.Models;

namespace TournamentLibrary.DataAccess.TextHelpers
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string filename)
        {
            return $"{ConfigurationManager.AppSettings["filepath"]}\\{filename}";
        }

        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }

        public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines)
        {
            List<PrizeModel> output = new List<PrizeModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                PrizeModel p = new PrizeModel();
                p.Id = int.Parse(cols[0]);
                p.PlaceNumber = int.Parse(cols[1]);
                p.PlaceName = cols[2];
                p.PriceAmount = decimal.Parse(cols[3]);
                p.PricePercentage = double.Parse(cols[4]);
                output.Add(p);
            }
            return output;
        }

        public static void SaveToPrizeFile(this List<PrizeModel> models, string filename)
        {
            List<string> lines = new List<string>();
            foreach (PrizeModel p in models)
            {
                lines.Add($"{p.Id},{p.PlaceNumber},{p.PlaceName},{p.PriceAmount},{p.PricePercentage}");
            }
            File.WriteAllLines(filename.FullFilePath(), lines);
        }


        public static List<PersonModel> ConvertToPersonModels(this List<string> lines)
        {
            List<PersonModel> output = new List<PersonModel>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                PersonModel p = new PersonModel();
                p.Id = int.Parse(cols[0]);
                p.Nombre = cols[1];
                p.Apellido = cols[2];
                p.Correo = cols[3];
                p.NumTelefono = cols[4];
                output.Add(p);
            }
            return output;
        }

        public static void SaveToPersonFile(this List<PersonModel> models, string filename)
        {
            List<string> lines = new List<string>();
            foreach (PersonModel p in models)
            {
                lines.Add($"{p.Id},{p.Nombre},{p.Apellido},{p.Correo},{p.NumTelefono}");
            }
            File.WriteAllLines(filename.FullFilePath(), lines);
        }

        public static List<TeamModel> ConvertToTeamModels(this List<string> lines, string peopleFileName)
        {
            List<TeamModel> output = new List<TeamModel>();
            List<PersonModel> person = peopleFileName.FullFilePath().LoadFile().ConvertToPersonModels();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                TeamModel t = new TeamModel();
                t.Id = int.Parse(cols[0]);
                t.TeamName = cols[1];

                string[] personId = cols[2].Split('|');

                foreach (string id in personId)
                {
                    t.TeamMemebers.Add(person.Where(x => x.Id == int.Parse(id)).First());
                }

                output.Add(t);
            }

            return output;
        }

        public static void SaveToTeamFile(this List<TeamModel> models, string filename)
        {
            List<string> lines = new List<string>();
            foreach (TeamModel t in models)
            {
                lines.Add($"{t.Id},{t.TeamName},{ConvertPeopleListToString(t.TeamMemebers)}");
                
            }

            File.WriteAllLines (filename.FullFilePath(), lines);
        }

        private static string ConvertPeopleListToString(List<PersonModel> people)
        {
            string output = "";

            if (people.Count == 0) return "";

            foreach (PersonModel p in people)
            {
                output += $"{ p.Id }|";
            }

            output= output.Substring(0,output.Length-1);

            return output;
        }
    }
}
