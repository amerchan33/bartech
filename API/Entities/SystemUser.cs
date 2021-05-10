namespace API.Entities
{
    public class SystemUser
    {
        public int SystemUserId { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public bool  IsDeleted { get; set; }
    }
}