using System.ComponentModel.DataAnnotations;

namespace AuxCordSite.Models
{
    public class Song
    {
        public int Id { get; set; }

        //track name as given by a user
        public string Name { get; set; }

        //actual file name/route, with the root directory added in when a song is saved
        public string AudioRoute { get; set; }
        public DateTime UploadTime { get; set; }
    }
}
