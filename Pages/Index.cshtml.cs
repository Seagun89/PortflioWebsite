using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using PortflioWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortflioWebsite.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public string Description { get; set; }
        public string LinkedInURL { get; set; }
        public int YearsOfExperience { get; set; }
        public string GithhubURL { get; set; }
        public List<string> Languages { get; private set; }
        public List<Project> Projects { get; set; }
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            this.Description = @"Experimental software engineer looking to broaden knowledge and experience on front-end as well as
                back-end engineering.Loves to problem solve challenging tasks with enthusiasm. Very inquisitive,
                capable to soak in information effortlessly. Able to write clear and concise code, debug, and provide
                leadership for business needs";
            this.LinkedInURL = "www.linkedin.com/in/george-tackie-a4bb4419b/";
            this.YearsOfExperience = 5;
            this.GithhubURL = "github.com/Seagun89";
            this.Languages = new List<string>() { "C# - Intermediate", "Java - Intermediate", "Python - beginner", "C++ - beginner"};

            Projects = new List<Project>() { 
                new Project(
                "Skiasharp Drawing Application", 
                "C#", 
                "Visual App that can be used to create Flowchart Diagrams, Business diagrams, and UML diagrams.",
                "github.com/Seagun89/Team19SKiaR12"),
                new Project(
                "Itiner-Buddy Bot",
                "Python",
                "Itiner-Buddy provides faster, more efficient and easier ways to schedule and manage meetings and record meeting results in Discord's channels.",
                "github.com/Seagun89/Itiner-Buddy-Bot"),
                new Project(
                "Software Computer Hardware Implementation",
                "Java",
                "A software version of how hardware is implemented for the builds of computers, learing the use of Bits, ALU, Memory, instruction stack and Registers.",
                "github.com/Seagun89/Software-comp-build"),
                new Project(
                "tic-tac-toe",
                "C++",
                "A simple implementation of the classic game of tic-tac-toe.",
                "github.com/Seagun89/tic-tac-toe-project")};
        }

        public string getSDA()
        {
            string SDA = "";
            var proj = from p in Projects where p.Name == "Skiasharp Drawing Application" select p;
            foreach (var info in proj)
            {
                SDA = info.print();
            }
            return SDA;
        }
        public string getIBB()
        {
            string IBB = "";
            var proj = from p in Projects where p.Name == "Itiner-Buddy Bot" select p;
            foreach(var info in proj)
            {
                IBB = info.print();
            }
            return IBB;
        }
        public string getSCHI()
        {
            string SCHI = "";
            var proj = from p in Projects where p.Name == "Software Computer Hardware Implementation" select p;
            foreach( var info in proj)
            {
                SCHI = info.print();
                
            }
            return SCHI;
        }
        public string getTTT()
        {
            string TTT = "";
            var proj = from p in Projects where p.Name == "tic-tac-toe" select p;
            foreach (var info in proj)
            {
                TTT = info.print();

            }
            return TTT;
        }
    }
}
