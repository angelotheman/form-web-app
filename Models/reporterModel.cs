using System.ComponentModel.DataAnnotations;
using System.Web;

namespace formApp.Models
{
    public class Address
    {
        [Key]
        public int Id { set; get; }
        public string? First_name { set; get; }
        public string? Last_name { set; get; }
        public string? Email { set; get; }
        public int Contact { set ; get; }
        /*[DataType(DataType.Upload)]
        public HttpPostedFileBase ImageFile { set; get; }
        */
        public Categories FaultTypes { set; get; }
    }

    public enum Categories {
        AirCondition,
        Painting,
        Materials,
        Fittings
    }
}