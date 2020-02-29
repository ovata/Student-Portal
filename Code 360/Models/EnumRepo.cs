using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Code_360.Models
{
        public enum Gender
        {
            Male = 1,
            Female
        }

        public enum AddmissionType
        {
            Paid = 1,
            Income_Sharing
        }

        public enum MaritalStatus
        {
            Single = 1,
            Married,
            Divorced,
            Complicated
        }

        public enum Level
        {
            Beginer = 1,
            Intermidiate,
            Expert
        }

        public enum StudentStatus
        {
            Graduted = 1,
            DropedOut,
            Disqualified,
            Differed,
            InProgress
        }

        public enum Grade
        {
            Distinction = 1,
            Excellent,
            VeryGood,
            Good,
            Fair,
            Bad
        }

        public enum ProjectStatus
        {
            Completed =1,
            Incomplete,
            Abandoned
        }

        public enum ProgramName
        {
            FrontEnd = 1,
            BackEnd,
            FullStack,
            Mobile_Development,
            Graphics_Designs
        }

        public enum ProgramDuration
        {
            Two_Months = 1,
            Three_Months,
            Four_Months,
            Five_Months,
            Six_Months
        }

        public enum CourseName
        {
            Html = 1,
            Css,
            C_Sharp,
            Asp_DotNet_Core,
            Xamarin,
            JS,
            SQL,
            Adobe_PhotoShop
        }

        public enum Relationship
    {
            Father = 1,
            Mother,
            Uncle,
            Aunty,
            Relative
        }
}
