namespace dndAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        
        public string nickName { get; set; }

        public string email { get; set; }
        
        public string password { get; set; }

        public bool deleted { get; set; }

    }
}
