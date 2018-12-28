using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace BeautifulXaml
{
    public class DataFactory
    {
        public static IList<GreatPlace> Places { get; private set; }
        public static IList<ExerciseClass> Classes { get; private set; }

        private static DateTime TodayAt(int hour, int minute)
        {
            return new DateTime(DateTime.Now.Year,
                DateTime.Now.Month,
                DateTime.Now.Day,
                hour, minute, 0);
        }

        static DataFactory()
        {

            Places = new ObservableCollection<GreatPlace>
            {
                new GreatPlace
                {
                    Title = "Fiji Getaway",
                    Handle = "@beachcomber",
                    ViewCount = 2654,
                    HeroImage = "Fiji.jpg",
                    ProfileImage = "Person_1.jpg"
                },
                new GreatPlace
                {
                    Title = "A Hipster day out",
                    Handle = "@handlebar",
                    ViewCount = 124,
                    HeroImage = "Hipster.jpg",
                    ProfileImage = "Person_4.jpg"
                                },
                new GreatPlace
                {
                    Title = "Mediteranian Bliss",
                    Handle = "@greekdude",
                    ViewCount = 562,
                    HeroImage = "greekisland.jpg",
                    ProfileImage = "Person_5.jpg"
                },
                new GreatPlace
                {
                    Title = "Down the slopes",
                    Handle = "@skibunny",
                    ViewCount = 132,
                    HeroImage = "snow.jpg",
                    ProfileImage = "Person_2.jpg"
                                },
                new GreatPlace
                {
                    Title = "Wide open road",
                    Handle = "@vroom",
                    ViewCount = 3221,
                    HeroImage = "combi.jpg",
                    ProfileImage = "Person_3.jpg"
                                },
            };

            Classes = new ObservableCollection<ExerciseClass>
            {
                new ExerciseClass
                {
                    ClassName = "Yoga",
                    Instructor = "Maharshi Patanjali",
                    ClassTime = TodayAt(8,00),
                },
                 new ExerciseClass
                {
                    ClassName = "ABS + Stretch",
                    Instructor = "David Hasslehoff",
                    ClassTime = TodayAt(9,30),
                },
                 //new ExerciseClass
                //{
                //    ClassName = "Body Sculpt",
                //    Instructor = "Sadie Terry",
                //    ClassTime = DateTime.Now.AddHours(3),
                //},
                 new ExerciseClass
                {
                    ClassName = "Cycle",
                    Instructor = "Lance Armstrong",
                    ClassTime = TodayAt(12,00),
                },
                 new ExerciseClass
                {
                    ClassName = "Aerobics",
                    Instructor = "Jacky Chan",
                    ClassTime = TodayAt(15,30),
                },
                 new ExerciseClass
                {
                    ClassName = "Weights",
                    Instructor = "Arnold Schwarzenegger",
                    ClassTime = TodayAt(18,00),
                    IsLast = true
                },
            };
        }
    }

}