using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Guide
    {
        //Rehberler
        [Key]
        public int GuideID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Description2 { get; set; }
        public string Image { get; set; }
        public string GuideListImage { get; set; }
        public string Twitterurl { get; set; }
        public string Instagramurl { get; set; }
        public bool Status { get; set; }
        public List<Destination> Destinations { get; set; }

    }
}
