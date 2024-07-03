using Microsoft.AspNetCore.Mvc;
using MadhuriPortfolio.Models;
using System.Collections.Generic;

namespace MadhuriPortfolio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Achievements()
        {
            var achievements = new List<Achievement>
            {
                new Achievement { Id = 1, Title = "Jr. Software Engineer", Description = "Accredited within a year", Date = "2023" },
                new Achievement { Id = 2, Title = "Codevita Rank", Description = "Secured 6806th rank in Codevita Season 9", Date = "2022" }
            };
            return View(achievements);
        }

        public IActionResult Certifications()
        {
            var certifications = new List<Certification>
            {
                new Certification { Id = 1, Title = "AZ-900 (Azure Fundamentals)", Institution = "Microsoft", Description = "Foundational knowledge of cloud services and Microsoft Azure" },
                new Certification { Id = 2, Title = "Machine Learning", Institution = "Coursera - Stanford Online", Description = "Broad introduction to machine learning by Andrew Ng" }
            };
            return View(certifications);
        }

        public IActionResult Experience()
        {
            var experiences = new List<Experience>
            {
                new Experience { Id = 1, Title = "Software Engineer Intern", Company = "Agilysys Inc", Location = "Alpharetta, Georgia", Date = "May 2024 - Present", Description = "Designing and developing a wristband check-in system" },
                new Experience { Id = 2, Title = "Graduate Teaching Assistant", Company = "Georgia State University", Location = "Atlanta, Georgia", Date = "Sep 2023 - April 2024", Description = "Revamped Python curriculum with interesting projects" }
            };
            return View(experiences);
        }

        public IActionResult Projects()
        {
            var projects = new List<Project>
            {
                new Project { Id = 1, Title = "SkySentiment", Description = "Elevating Airline Service with NLP", Link = "https://github.com/MadhuriSakhamuri/SkySentiment" },
                new Project { Id = 2, Title = "AdaptNet", Description = "Revolutionizing Network Dynamics", Link = "https://github.com/MadhuriSakhamuri/AdaptNet" }
            };
            return View(projects);
        }

        public IActionResult Education()
        {
            var education = new List<Education>
            {
                new Education { Id = 1, Degree = "Master’s in Computer Science", Institution = "Georgia State University", Date = "Aug 2023 – Dec 2024", CGPA = 4.1 },
                new Education { Id = 2, Degree = "Bachelor’s in Computer Science & Engineering", Institution = "R.V.R & J.C. College of Engineering", Date = "Jul 2017 – Jun 2021", CGPA = 3.8 }
            };
            return View(education);
        }

        public IActionResult Skills()
        {
            var skills = new List<Skill>
            {
                new Skill { Id = 1, Name = "Python" },
                new Skill { Id = 2, Name = "C" },
                new Skill { Id = 3, Name = "C#" },
                new Skill { Id = 4, Name = "SQL" },
                new Skill { Id = 5, Name = "NoSQL" }
            };
            return View(skills);
        }
    }
}
