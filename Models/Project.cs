using System;

namespace PortflioWebsite.Models
{
    public class Project
    {
        public string project = " ";
        public string Name { get; set; }
        public string Language { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }

        public Project(string name, string lang, string descrip, string link)
        {
            this.Name = name;
            this.Language = lang;
            this.Description = descrip; 
            this.Link = link;
        }

        public string print()
        {
            return "Project Name: " + Name + " | " + "Language: " + Language + " | " + Description + " | " + Link;
        }
    }
}
