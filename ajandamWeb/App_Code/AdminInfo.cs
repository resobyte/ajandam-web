using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// AdminInfo için özet açıklama
/// </summary>
public class AdminInfo
{
    public class Datum
    {
        public int id { get; set; }
        public string name { get; set; }
        public int number { get; set; }
        public string surname { get; set; }
        public string macId { get; set; }
    }

    public class Academician
    {
        public int id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string username { get; set; }
        public string department { get; set; }
        public string faculty { get; set; }
    }

    public class Lesson
    {
        public int id { get; set; }
        public string name { get; set; }
        public Academician academician { get; set; }
        public string clock { get; set; }
        public string day { get; set; }
        public string location { get; set; }
    }

    public class RootObject
    {
        public List<Datum> data { get; set; }
        public List<Lesson> lessons { get; set; }
    }

}