namespace WebsiteAPI.Dtos
{
    public class OutletReadDtos
    {
         public int id { get; set; }
        
        
        public string OutletName { get; set; }

        public string StreetName { get; set; }

        public string Landmark { get; set; }
        public int No_of_AvaiFoodItems { get; set; }
        public int Req_Volunteer { get; set; }

        public int OrderDate { get; set; }
    }
}