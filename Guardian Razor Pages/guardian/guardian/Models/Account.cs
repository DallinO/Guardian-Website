namespace guardian.Models
{
    public class Account
    {
        /* Primary Info **************/
        public int Id { get; set; }
        public string Username { get; set; }
        public string Nickname { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
    }

    public enum Gender
    {
        male,
        female
    }

    public enum Rank
    {
        Legionnaire
    }
}
