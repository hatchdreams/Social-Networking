using System;

namespace DatingApp.API.Dtos
{
    public class PhotosForDetailedDto
    {
        public int Id { get; set; }
        public string URL { get; set; }
        public string Desc { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsMain { get; set; }

    }
}