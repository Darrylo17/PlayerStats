using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlayerStatsProject.Models
{
    [Table("Players")]
    public class Players
    {
        [Key]
        public long PlayerID { get; set; } 

        public string Name { get; set; } = string.Empty;
        public string Nationality { get; set; } = string.Empty;
        public string National_Position { get; set; } = string.Empty;
        public int National_Kit { get; set; }
        public string Club { get; set; } = string.Empty;
        public string Club_Position { get; set; } = string.Empty;
        public int Club_Kit { get; set; }
        public DateTime Club_Joining { get; set; }
        public int Contract_Expiry { get; set; }
        public int Rating { get; set; }
        public string Height { get; set; } = string.Empty;
        public string Weight { get; set; } = string.Empty;
        public string Preferred_Foot { get; set; } = string.Empty;
        public DateTime Birth_Date { get; set; }
        public int Age { get; set; }
        public string PreferredPosition { get; set; } = string.Empty;
        public string Work_Rate { get; set; } = string.Empty;
        public int Weak_Foot { get; set; }
        public int Skill_Moves { get; set; }
        public int Ball_Control { get; set; }
        public int Dribbling { get; set; }
        public int Marking { get; set; }
        public int Sliding_Tackle { get; set; }
        public int Standing_Tackle { get; set; }
        public int Aggression { get; set; }
        public int Reactions { get; set; }
        public int Attacking_Position { get; set; }
        public int Interceptions { get; set; }
        public int Vision { get; set; }
        public int Composure { get; set; }
        public int Crossing { get; set; }
        public int Short_Pass { get; set; }
        public int Long_Pass { get; set; }
        public int Acceleration { get; set; }
        public int Speed { get; set; }
        public int Stamina { get; set; }
        public int Strength { get; set; }
        public int Balance { get; set; }
        public int Agility { get; set; }
        public int Jumping { get; set; }
        public int Heading { get; set; }
        public int Shot_Power { get; set; }
        public int Finishing { get; set; }
        public int Long_Shots { get; set; }
        public int Curve { get; set; }
        public int Freekick_Accuracy { get; set; }
        public int Penalties { get; set; }
        public int Volleys { get; set; }
        public int GK_Positioning { get; set; }
        public int GK_Diving { get; set; }
        public int GK_Kicking { get; set; }
        public int GK_Handling { get; set; }
        public int GK_Reflexes { get; set; }
    }
}
